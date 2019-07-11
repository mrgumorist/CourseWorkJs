using DAL.Entities;
using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        List<Transaction> Get5Transactions();
        bool Login(string email, string pass);
        bool Register(string login, string password, string email);
        double GetCourse(string shortname);
    }
}
