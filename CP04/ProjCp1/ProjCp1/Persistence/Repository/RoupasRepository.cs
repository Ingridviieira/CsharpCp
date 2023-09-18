using Microsoft.EntityFrameworkCore;
using ProjCp1.Models;

namespace ProjCp1.Persistence.Repository
{
    public class RoupasRepository : IARoupasRepository
    {

        private readonly Contexto _dbContext;

        public RoupasRepository(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public Roupas GetById(int id)
        {
            return _dbContext.Roupas.Find(id);
        }

        public IEnumerable<Roupas> GetAll()
        {
            return _dbContext.Roupas.ToList();
        }

        public void Add(Roupas entity)
        {
            _dbContext.Roupas.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Roupas entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Roupas entity)
        {
            _dbContext.Roupas.Remove(entity);
                _dbContext.SaveChanges();
        }
    }
}