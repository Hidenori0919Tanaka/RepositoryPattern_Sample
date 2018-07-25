using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Repository
{
    public interface IBookRepository<T>
    {
        T GetOne(int id);
        List<T> GetAll();
    }
}
