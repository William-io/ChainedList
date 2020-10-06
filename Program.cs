using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class List
    {
        private No _glass, _water;

        //Inserir elemento no fim da lista
        public void InsertEnd(string element)
        {
            No newNo = new No();
            newNo.Value = element;

            if (_glass == null)
            {
                _glass = newNo;
            }
            else
            {
                _water.Next = newNo;
            }
        }


    }
}
