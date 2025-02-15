using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Iterator.GoF
{
    public class Book
    {
        private int _id;
        private string _name;

        public Book(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
