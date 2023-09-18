using ProjCp1.Models;

namespace ProjCp1.Persistence.Repository
{
    public interface IARoupasRepository
    {
        Roupas GetById(int id);
        IEnumerable<Roupas> GetAll();
        void Add(Roupas entity);
        void Update(Roupas entity);
        void Delete(Roupas entity);
    }
}
