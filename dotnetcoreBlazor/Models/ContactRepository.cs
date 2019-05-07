using dotnetcoreBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreBlazor.Models
{
    public class ContactRepository : IContactRepository
    {
        private readonly DBContext _dbContext;

        public ContactRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddRecord(Contact contact)
        {
            _dbContext.Contact.Add(contact);
            _dbContext.SaveChanges();
        }

        public void DeleteRecord(int id)
        {
            var entity = _dbContext.Contact.First(t => t.ID == id);
            _dbContext.Contact.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Contact> GetRecords()
        {
            return _dbContext.Contact.ToList();
        }

        public Contact GetSingleRecord(int id)
        {
            return _dbContext.Contact.First(t => t.ID == id);
        }

        public void UpdateRecord(Contact contact)
        {
            _dbContext.Contact.Update(contact);
            _dbContext.SaveChanges();
        }
    }
}
