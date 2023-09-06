using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaePilha
{
    internal class Pilha
    {
        private List<string> _list = new List<string>();

        public void enstack(string elemento)
        {
            _list.Add(elemento);    
        }

        public void destack()
        {
            int ultimoIndex = _list.Count - 1;
            _list.RemoveAt(ultimoIndex);
        }

        public void getAll()
        {
            Console.WriteLine("++++");
            foreach(var item in _list)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
