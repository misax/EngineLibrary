using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineLibrary.Interface;

namespace EngineLibrary
{
    public class Engine : ICreateEngine,IList<Engine>,IList<int>
    {
        IList<Engine> engine = new List<Engine>();
        public int Power { get; set; }

        public bool Remove(int item)
        {
            if (Power == 0 || item == 0)
            {
                return false;
            }
            if (engine.Contains(engine))
            {
                return true;
            }
            if (engine == null)
            {
                throw new ArgumentNullException();
            }
            return item > 0 ? true : false;
        }

        public int Count => engine.Count;

        public bool IsReadOnly => true;

        public Engine this[int index] { get => engine[index];
            set => engine[index] = value;
        }

        public Engine()
        {
            
        }
        public Engine(int power)
        {
            Power = power;
        }

        public void Add(int power)
        {
            var p = engine[power++];
            engine = p;
          //var powers = new Engine(power);
          //  if(powers.Power > 0)
          //       powers.Power += 100;
          //  if(powers == null)
          //      powers = new Engine();
        }

        public Engine AddPower(Engine engine)
        {
            engine.Power = engine.Power;
            return engine;
        }

        public int IndexOf(Engine item)
        {
           return engine.IndexOf(item);
        }

        public void Insert(int index, Engine item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            if (index <= 0 || index > 10000)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (item != null || index > 0 && index < 10000)
            {
                engine.Insert(index, item);
            }
            else
            {
                return;
            }
        }

        public int IndexOf(int item)
        {
            var engine0 = (Engine) engine;
            if (engine0 is Engine)
            {
                return engine.IndexOf(engine0);
            }
            return -1;
        }
            

        public void Insert(int index, int item)
        {
            var e = engine as Engine;
            if (e is Engine)
            {
                engine.IndexOf(e);
            }
            throw new InvalidOperationException();
          
        }

        public void RemoveAt(int index)
        {
            engine.RemoveAt(index);
        }

        int IList<int>.this[int index]
        {
            get => engine.IndexOf(engine[index]);
            set
            {
                var indexOf = engine.IndexOf(engine[index]);
                indexOf = value;
            }
        }

        public void Add(Engine item)
        {
            engine.Add(item);
        }

        public void Clear()
        {
            var count = engine.Count;
            count = 0;
            engine = null;
        }

        public bool Contains(int item)
        {
            var e = engine as Engine;
           return  engine.Contains(e);
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            var e = engine as Engine;
            if (e != null)
            {
               var compare = e.Power.CompareTo(array[arrayIndex]);

                if (compare > 0)
                {
                    e.CopyTo(new Engine[array[arrayIndex]],array[arrayIndex]);
                }
            }
        }

        public bool Contains(Engine item)
        {
            return engine.Contains(item);
        }

        public void CopyTo(Engine[] array, int arrayIndex)
        {
           engine.CopyTo(array,arrayIndex);
        }

        public bool Remove(Engine item)
        {
           return  engine.Remove(item);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            var rator = GetEnumerator();
            while (rator.MoveNext())
            {
                var en = engine[engine.Count];
                yield return Convert.ToInt32(rator.Current);
            }
        }

        public IEnumerator<Engine> GetEnumerator()
        {
            foreach (var en in engine)
            {
                if (en != null)
                {
                    yield return en;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
