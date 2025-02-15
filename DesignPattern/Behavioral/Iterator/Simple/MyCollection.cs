using System.Collections;

namespace DesignPattern.Behavioral.Iterator.Simple
{
    public class MyCollection : IEnumerable
    {
        private int[] _arr;

        public MyCollection(int[] arr)
        {
            _arr = arr;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyIterator(this);
        }

        private class MyIterator : IEnumerator
        {
            private MyCollection _collection;
            private int _currentIndex = -1;

            public MyIterator(MyCollection collection)
            {
                _collection = collection;
            }

            public object Current
            {
                get
                {
                    if (_currentIndex == -1 || _currentIndex >= _collection._arr.Length)
                        throw new InvalidOperationException();
                    return _collection._arr[_currentIndex];
                }
            }

            public bool MoveNext()
            {
                _currentIndex++;
                return _currentIndex < _collection._arr.Length;
            }

            public void Reset()
            {
                _currentIndex = -1;
            }
        }
    }
}
}
