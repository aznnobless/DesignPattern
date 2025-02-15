namespace DesignPattern.Behavioral.Iterator.GoF
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;

        }    
            
        public bool HasNext()
        {
            if (_index < _bookShelf.Length)
            {
                return true;
            }

            return false;

        }

        public object Next()
        {
            var book = _bookShelf.Get(_index);
            _index++;
            return book;
        }
    }
}
