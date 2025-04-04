namespace BB208LibraryManagement;

public class Library
{

    private Book[] _books;
    public Book[] Books { get { return _books; } set { _books = value; } }

    public Library()
    {
        Books = [];
    }

    public void AddBookToLibrary(Book book)
    {
        Array.Resize(ref _books, Books.Length + 1);
        Books[Books.Length - 1] = book;
    }

    public void ShowAllBooksInfo()
    {
        foreach (Book book in Books)
        {

            book.InfoBook();
        }
    }
}


public abstract class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public GenreEnum Genre { get; set; }


    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }


    public abstract void InfoBook();

}


public class ElectronBook : Book
{
    public string FileExtension { get; set; }

    public ElectronBook(string title, string author, GenreEnum genre) : base(title, author)
    {

    }

    public override void InfoBook()
    {
        Console.WriteLine("Burada sizin reklaminiz ola bilerdi ElectronBook(GSMF)");

    }
}

public class AudioBook : Book
{


    public AudioBook(string title, string author) : base(title, author)
    {

    }

    public override void InfoBook()
    {
        Console.WriteLine("Burada sizin reklaminiz ola bilerdi AudioBook(GSMF)");
    }
}
