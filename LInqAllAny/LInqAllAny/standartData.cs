using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqAllAny
{
    public class standartData
    {
        public static readonly List<Standart> standarts = new List<Standart>()
        {
            new Standart(){StandartId = 1, Name = "Standart 1"},
            new Standart(){StandartId = 2, Name = "Standart 2"},
            new Standart(){StandartId = 3, Name = "Standart 3"},
        };
    }
}
