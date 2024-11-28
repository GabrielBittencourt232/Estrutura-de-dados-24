using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaLinkadaCircular
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        public new IEnumerator<T> GetEnumerator()
        {
            return new CircularLinkedListEnumerator<T>(this);
        }
    }
}