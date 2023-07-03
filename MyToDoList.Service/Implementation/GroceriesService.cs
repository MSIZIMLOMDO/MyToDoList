using MyToDoList.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.DAL.Interface;
using MyToDoList.Data;


namespace MyToDoList.Service.Implementation
{
    public class GroceriesService: IGroceriesService
    {
        private IGroceriesRepository _groceriesRepository;

        public GroceriesService(IGroceriesRepository roomTypeRepository)
        {
            _groceriesRepository = roomTypeRepository;
        }

        public List<Groceries> GetGroceries()
        {
            return _groceriesRepository.GetGroceries();
        }
        public Groceries GetGroceries(int id)
        {
            return _groceriesRepository.GetGroceries(id);
        }
        public bool Insert(Groceries groceries, string currentUserID)
        {
            return _groceriesRepository.Insert(groceries, currentUserID);
        }
        public bool Update(Groceries groceries, string currentUserID)
        {
            return _groceriesRepository.Update(groceries, currentUserID);
        }
        public IEnumerable<Groceries> Find(Func<Groceries, bool> predicate)
        {
            return _groceriesRepository.Find(predicate);
        }
        public bool Delete(Groceries groceries)
        {
            return _groceriesRepository.Delete(groceries);
        }
    }
}
