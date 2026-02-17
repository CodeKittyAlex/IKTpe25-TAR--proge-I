using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.modles
{
    public class PeopleData
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>
        {
            new PeopleList()
            {
                id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("0131ba86-9357-4221-a0c3-85f526780d44")
            },
            new PeopleList()
            {
                id = 2,
                Name = "poona",
                Age = 21,
                GenderId = Guid.Parse("099c2f67-ff56-4df8-9ac0-2865b4fb5337")
            },
            new PeopleList()
            {
                id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("099c2f67-ff56-4df8-9ac0-2865b4fb5337")
            },
            new PeopleList()
            {
                id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("0131ba86-9357-4221-a0c3-85f526780d44")
            },
            new PeopleList()
            {
                id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("0131ba86-9357-4221-a0c3-85f526780d44")
            },
            new PeopleList()
            {
                id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("0131ba86-9357-4221-a0c3-85f526780d44")
            },
            new PeopleList()
            {
                id = 7,
                Name = "bill",
                Age = 21,
                GenderId = Guid.Parse("099c2f67-ff56-4df8-9ac0-2865b4fb5337")
            },
        };
    }
}
