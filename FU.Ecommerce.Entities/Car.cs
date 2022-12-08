namespace FU.Ecommerce.Entities;

public class Car
{
    public int CarId { get; set; }
    public string CarName { get; set; }
    public string Manufacture { get; set; }
    public decimal ListPrice { get; set; }
    public DateTime ReleaseDate { get; set; }

    public Car()
    {
    }
    public Car(int carId, string carName, string manufacture, decimal listPrice, DateTime releaseDate)
    {
        CarId = carId;
        CarName = carName;
        Manufacture = manufacture;
        ListPrice = listPrice;
        ReleaseDate = releaseDate;
    }
    
}