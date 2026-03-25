using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheridence2
{
    //river on antud juhul alamklass ja viitab waterile e pealmisele classile
    //public 
    class river : water
    {
        //kui kirjutan override, siis kirjutab water meetodis oleva DoSomething meedoti üle
        //kui panen siia public virtual void, siis ei kirjuta meetodi Dosomething-t üle
        //public void riverMethod()
        public override void DoSomething()
        {
            //water classis on olemas muutuja flow ja length ja sellepärast ei pea neid siin uuesti defineerima
            Console.WriteLine("this river method and it has " + flow + " and " +  Length +"is in meters");
        }
    }
}
