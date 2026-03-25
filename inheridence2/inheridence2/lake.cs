using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheridence2
{
    class lake : water
    {
        public override void DoSomething()
        {
            //water classis on olemas muutuja flow ja length ja sellepärast ei pea neid siin uuesti defineerima
            Console.WriteLine("lake method");
        }
    }
}
