using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineLibrary;
using EngineLibrary.Interface;

namespace EngineUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var en = new Engine(10);
            Engine[] engine = new Engine[]{new Engine(5),new Engine(10), new Engine(20),  };
            ICreateEngine create = en.AddPower(en);
            create.Add(10);

            engine.CopyTo(new Engine[en.Count - 1],10 );

        }
    }
}
