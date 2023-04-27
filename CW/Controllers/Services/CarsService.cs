using CW.Controllers.Data;
using CW.Models;

namespace CW.Controllers.Services
{
    public class CarsService : ICarsService
    {
        private readonly AppDbContext _context;

        public CarsService(AppDbContext context)
        {
            _context = context;
        }
    
        public void Add(CarsModel Car)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarsModel> GetAll()
        {
            var result = _context.Cars.ToList();
            return result;
        }

        public CarsModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CarsModel Update(int id, CarsModel newCar)
        {
            throw new NotImplementedException();
        }
    }
}
