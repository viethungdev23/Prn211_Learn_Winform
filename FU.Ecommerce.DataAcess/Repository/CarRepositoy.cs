
using FU.Ecommerce.DataAcess.DataAcess;
using FU.Ecommerce.Entities;

namespace FU.Ecommerce.DataAcess.Repository;
public class CarRepositoy : ICarRepository
{
    public void Add(Car car)
    {
        try
        {
            CarDBContext.Instance.AddNew(car);
        }catch(Exception ex)
        {
            throw;
        }
    }

    public void Delete(Car car) => CarDBContext.Instance.Remove(car);

    public IList<string> GetAllManufactures()
    => CarDBContext.Instance.Manufactures.ToList();

    public Car? GetCarById(int carId) => CarDBContext.Instance.GetCarById(carId);
    
    public IEnumerable<Car> GetCars() => CarDBContext.Instance.CarList.ToList();

    public void Update(Car car) => CarDBContext.Instance.Update(car);
    
}
