using System;

namespace ChainedList
{
    class List
    {
        private No _glassCup, _plasticCup;

        //Inserir elemento no fim da lista
        public void InsertEnd(string element)
        {
            No newNo = new No();
            newNo.Value = element;

            if (_glassCup == null)
            {
                _glassCup = newNo;
            }
            else
            {
                _plasticCup.Next = newNo;
            }
        }

        //Inserir elemento no inicio da lista
        public void InsertBeginning(string element)
        {
            No newBrand = new No();
            newBrand.Value = element;

            if (_glassCup == null)
            {
                _glassCup = newBrand;
                _plasticCup = newBrand;
            }
            else
            {
                newBrand.Next = _glassCup;
            }
            _glassCup = newBrand;
        }

        //Retirar elemento do fim da lista

        public void RemoveEnd()
        {
            if (_glassCup == null)
            {
                return;
            }
            if (_glassCup.Next == null)
            {
                Console.WriteLine($"Foi retirado o elemento: {_glassCup.Value}");
                _glassCup = null;
            }
            else
            {
                No last = _glassCup.Next;
                No penultimate = _glassCup;

                while (last.Next != null)
                {
                    penultimate = last;
                    last = last.Next;
                }
                penultimate.Next = null;
                Console.WriteLine($"Esse Elemento que foi retirado: {last.Value}");
            }
            this.display();
        }


        //Retirar elemento do inicio da lista
        public void RemoveBeginning()
        {
            if (_glassCup != null)
            {
                Console.WriteLine($"Esse Elemento foi retirado: {_glassCup.Value}");
                _glassCup = _glassCup.Next;
            }
            display();
        }

        //Exibir elementos da lista
        public void display()
        {
            if (_glassCup != null)
            {
                No temp = _glassCup;
                while (temp != null)
                {
                    Console.Write(temp.Value + " ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Lista agora está vazia");
            }
        }


    }
}
