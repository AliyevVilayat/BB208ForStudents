namespace BB208LibraryManagement;

public class Program
{
    static void Main(string[] args)
    {
        ElectronBook electronBook = new ElectronBook("TestTitle", "TestAuthor", GenreEnum.Psixologiya);
        AudioBook audioBook = new AudioBook("TestTitle", "TestAuthor");
        Library library = new Library();

        library.AddBookToLibrary(electronBook);
        library.AddBookToLibrary(audioBook);

        library.ShowAllBooksInfo();
    }
}

