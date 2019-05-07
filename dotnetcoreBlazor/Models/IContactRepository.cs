using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreBlazor.Models
{
    public interface IContactRepository
    {
        void AddRecord(Contact contact);
        void UpdateRecord(Contact contact);
        void DeleteRecord(int id);
        Contact GetSingleRecord(int id);
        List<Contact> GetRecords();
    }
}
