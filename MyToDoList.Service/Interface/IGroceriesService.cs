using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.Data;

namespace MyToDoList.Service.Interface
{
    public interface IGroceriesService
    {
        List<Groceries> GetGroceries();
        Groceries GetGroceries(int id);
        bool Insert(Groceries groceries, string currentUserID);
        bool Update(Groceries groceries, string currentUserID);
        bool Delete(Groceries groceries);
        IEnumerable<Groceries> Find(Func<Groceries, bool> predicate);
    }
}
