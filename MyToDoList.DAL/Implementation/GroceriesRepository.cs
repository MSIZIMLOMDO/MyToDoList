using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.DAL.Interface;
using MyToDoList.Data;

namespace MyToDoList.DAL.Implementation
{
    public class GroceriesRepository: IGroceriesRepository
    {
        private DatabaseService<Groceries> _databaseService;
        public GroceriesRepository(DatabaseService<Groceries> databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Groceries> GetGroceries()
        {
            return _databaseService.Get().ToList();
        }
        public Groceries GetGroceries(int id)
        {
            return _databaseService.Get(id);
        }
        public bool Insert(Groceries groceries, string currentUserID)
        {
            return _databaseService.Insert(groceries, currentUserID);
        }
        public bool Update(Groceries groceries, string currentUserID)
        {
            return _databaseService.Update(groceries, currentUserID);
        }
        public IEnumerable<Groceries> Find(Func<Groceries, bool> predicate)
        {
            return _databaseService.Find(predicate);
        }
        public bool Delete(Groceries groceries)
        {
            return _databaseService.Delete(groceries);
        }
    }
}
