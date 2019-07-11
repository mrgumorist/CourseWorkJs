using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EDAL : IDAL
    {
        private readonly Contextt _ctx = new Contextt();
        public List<Transaction> Get5Transactions()
        {
            return _ctx.Transactions.ToList().Skip(Math.Max(0, _ctx.Transactions.ToList().Count() - 5)).ToList();
        }
        public bool Login(string email, string pass)
        {
            var list = _ctx.Users.ToList();
            bool founded = false;
            for (int i =0; i<list.Count();i++)
            {
                if(list[i].Email== email)
                {
                    if(list[i].Password== pass)
                    {
                        founded = true;
                        list[i].LastLogin=DateTime.Now;
                       
                        break;
                    }
                    break;
                }
            }
            _ctx.SaveChanges();
            return (founded);
        }
        public bool Register(string login, string password, string email)
        {
            
                _ctx.Users.Add(new User() { Email = email, Login = login, Password = password , LastLogin= DateTime.MinValue});
                _ctx.SaveChanges();
           
                return true;
          
        }
        public double GetCourse(string shortname)
        {
            List<Coin> coins = _ctx.Coins.ToList();
            for(int i=0; i< coins.Count(); i++)
            {
                if(coins[i].ShortName==shortname)
                {
                    return coins[i].PriceInBugs;
                }
            }
            return 0.00;
        }
        public void AddTransaction(string fromName, string toName, string from, string to)
        {
            _ctx.Transactions.Add(new Transaction() { FromName = fromName, ToName = toName, CountFrom = from, CountTo = to });
            _ctx.SaveChanges();
        }
        public List<User> GetAllUsers()
        {
            return _ctx.Users.ToList();
        }
        public List<Transaction> GetAllTransactions()
        {
            return _ctx.Transactions.ToList();
        }
    }
}
