using CW.Models;

namespace CW.Controllers.Services
{
    public interface ICarsService
    {
        IEnumerable<CarsModel> GetAll();

        CarsModel GetById(int id);

        void Add (CarsModel Car);

        CarsModel Update(int id, CarsModel newCar);

        void Delete(int id);
    }
}
