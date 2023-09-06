using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaePilha
{
    internal class Fila
    {
        private List<string> _List = new List<string>();

        public void enqueue(string elemento)
        {
            _List.Add(elemento);
        }

        public void dequeue()
        {
            _List.RemoveAt(0);
        }

        public void getAll()
        {
            Console.WriteLine("+++++");
            foreach(var item in _List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
