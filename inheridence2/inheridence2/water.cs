using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheridence2
{
    public class water 
    {
        public bool flow;
        public string Length;
        //siin on DoSomething meetod, mida siis viitakse river classi all
        //see võib olla virtual ja ei pea panema override kuna teda kirjutatakse üle
        public virtual void DoSomenthing()
        {
            Console.WriteLine("do something method");
        }
        
    }
}
