using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineLibrary.Interface
{
    public interface ICreateEngine
    {
        void Add(int power);
        Engine AddPower(Engine engine);
    }
}
