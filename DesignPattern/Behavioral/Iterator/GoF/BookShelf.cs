namespace DesignPattern.Behavioral.Iterator.GoF
{
    public class BookShelf : Aggregate
    {
        private Book[] _books;
        private int _last;

        public BookShelf(int maxSize)
        {
            _books = new Book[maxSize];
        }
        public Book Get(int index)
        {
            if (index < 0 || index >= _books.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books[_last] = book;
            _last++;
        }

        public int Length => _last; 

        public Iterator Iterator()
        {
            throw new NotImplementedException();
        }
    }
}
