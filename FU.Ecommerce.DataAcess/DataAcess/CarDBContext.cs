using FU.Ecommerce.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace FU.Ecommerce.DataAcess.DataAcess;

public sealed class CarDBContext
{
    private SqlConnection _connection;
    private SqlCommand _command;
    private SqlDataReader _reader;
    private string _sql;

    private IList<Car> _carList()
    {
        List<Car> cars = new List<Car>();
        _connection = new SqlConnection(GetConnectString());
        _sql = "select * from cars";
        _command = new SqlCommand(_sql, _connection);

        // bat dau goi xuong database
        try
        {
            _connection.Open();
            _reader= _command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (_reader.HasRows)
            {
                while(_reader.Read())
                {
                    Car car = new Car();
                    car.CarId = _reader.GetInt32("CarId");
                    car.CarName = _reader.GetString("CarName");
                    car.Manufacture = _reader.GetString("Manufacturer");
                    car.ListPrice = _reader.GetDecimal("ListPrice");
                    car.ReleaseDate = _reader.GetDateTime("ReleaseDate");

                    cars.Add(car);
                }
            }
        }catch(Exception ex)
        {

        }
        return cars;
    }
    /*
    private static IList<Car> _carList = new List<Car>(){
        new Car{CarId = 1, CarName = "CRV", Manufacture = "Honda", ListPrice = 1200.5m, ReleaseDate = new DateTime(2020,10,03)},
        new Car{CarId = 2, CarName = "FORE", Manufacture = "Honda", ListPrice = 1300.5m, ReleaseDate = new DateTime(2020,10,03)},
        new Car{CarId = 3, CarName = "CRV", Manufacture = "acc", ListPrice = 1203.5m, ReleaseDate = new DateTime(2010,11,03)},
        new Car{CarId = 4, CarName = "AAA", Manufacture = "Honda", ListPrice = 4200.5m, ReleaseDate = new DateTime(2020,10,03)}
        };
    */

    private IList<string> _manufactures = new List<string>
    {
        "Honda",
        "Ford",
        "Audi",
        "BMW"
    };
    //<using singlton design pattern
    private static CarDBContext _instance = null;
    private static readonly object _instanceLock = new object();
    private CarDBContext() { } // very importance

    public static CarDBContext Instance
    {
        get
        {
            /* neu co multithreading thi se lock tung luong*/
            lock (_instanceLock)
            {
                if (_instance == null) _instance = new CarDBContext();
            }
            return _instance;
        }
    }
    //</using singlton design pattern


    public IList<Car> CarList { get => _carList(); }
    public IList<string> Manufactures { get => _manufactures; set => _manufactures = value; }


    // thuoc tinhs return _carlist

    public void AddNew(Car c)
    {
        // check xem car co trong list chuwa 
        Car car = CarList.FirstOrDefault(e => e.CarId == c.CarId);

        if (car is null)
        {
            CarList.Add(c);
        }
        else
        {
            throw new Exception("car is exit");
        }
    }

    public Car? GetCarById(int? id) => CarList.SingleOrDefault(c => c.CarId == id);

    public void Update(Car c)
    {
        Car car = CarList.FirstOrDefault(e => e.CarId == c.CarId);
        if (car is not null)
        {
            var index = CarList.IndexOf(car);
            CarList[index] = c;
        }
        else
        {
            throw new Exception($"carId: {car.CarId} is not found...");
        }
    }

    public void Remove(Car c)
    {
        // check c co ton tai k 
        // lay chi so c co
        var car = CarList.FirstOrDefault(e => e.CarId == c.CarId);
        if (car is not null)
        {
            CarList.Remove(car);
        }
        else
        {
            throw new Exception($"carid {c.CarId} is not found...");
        }
    }
    //get connection string tu file appsettings.json
    private string GetConnectString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",true,true)
            .Build();

        return config["ConnectionStrings:MyCarConnDB"];
    }
}