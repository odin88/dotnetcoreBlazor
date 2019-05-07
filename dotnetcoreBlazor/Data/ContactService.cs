using dotnetcoreBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreBlazor.Data
{
    public class ContactService
    {
        private readonly DbContext _dbContext;
        public ContactService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public Task<Contact[]> GetContactsAsync()
        //{
        //    using (_dbContext)
        //    {
        //        // do stuff
              

        //    }
        //}
    }
}
