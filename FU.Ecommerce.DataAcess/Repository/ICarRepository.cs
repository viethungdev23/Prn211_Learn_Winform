using FU.Ecommerce.Entities;

namespace FU.Ecommerce.DataAcess.Repository;
public interface ICarRepository
{
    IEnumerable<Car> GetCars();
    Car? GetCarById(int carId);
    void Update(Car car);
    void Add(Car car);
    void Delete(Car car);

    IList<string> GetAllManufactures();
}
