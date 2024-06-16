using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Double_Linked_List
{
    internal class Node<T> where T: IEquatable<T>
    {
        public T Data { get; set; }
        public Node<T> ?Next { get; set; }

        public Node <T> ?Previous { get; set; }

        public Node(T data) 
        {
            Data = data;
            Next = null;
            Previous = null;
        }

        public override bool Equals(object ?obj) 
        {

            return obj is Node<T>  other &&
                this.Data.Equals(other.Data);
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null || this.GetType() != obj.GetType())
        //    {
        //        return false;
        //    }
        //    Node<T> other = (Node<T>)obj;
        //    return EqualityComparer<T>.Default.Equals(this.Data, other.Data);
        //}

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Data);
        }
    }
}
