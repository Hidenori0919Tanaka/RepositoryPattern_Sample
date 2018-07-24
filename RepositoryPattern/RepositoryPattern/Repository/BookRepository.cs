using RepositoryPattern.Entity;
using RepositoryPattern.Entity.RepositoryPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPattern.Repository
{
    public class BookRepository : IBookRepository<Book>
    {
        private BookDbContext dbContext;
        public BookRepository()
        {
            this.dbContext = new BookDbContext();
        }

        public Book GetOne(int id)
        {
            return this.dbContext.Set<Book>().Find(id);
        }
    }
}