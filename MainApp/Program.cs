using System.Runtime.InteropServices;
using Domain;
using Domain.Models;
using Infrastructure;

var bookser = new BookServices();
var authorservice = new AuthorServices();
var genreser = new GenreServices();


System.Console.WriteLine("For using Author show : 1");
System.Console.WriteLine("For using Books show : 2");
System.Console.WriteLine("For using Genre show : 3");


var com = Console.ReadLine();
if (com == "1")
{
    while (true)
    {
        System.Console.WriteLine("c = Create");
        System.Console.WriteLine("r = Read");
        System.Console.WriteLine("u = Update");
        System.Console.WriteLine("d = Delete");
        System.Console.WriteLine("e = Exit");

        string command = Console.ReadLine();

        if (command == "c")
        {
            var authorr = new Author();
            System.Console.Write("Enter Author`s FirstName : ");
            authorr.FirstName = Console.ReadLine();
            System.Console.Write("Enter Author`s LastName : ");
            authorr.LastName = Console.ReadLine();
            System.Console.WriteLine("Author successfully created ! ");
            authorservice.AddAuthor(authorr);
            System.Console.WriteLine("----------------------------------------");
        }

        if (command == "r")
        {
            foreach (var item in authorservice.GetAuthor())
            {
                System.Console.WriteLine("Id : " + item.Id);
                System.Console.WriteLine("FirstName : " + item.FirstName);
                System.Console.WriteLine("LastName : " + item.LastName);
                System.Console.WriteLine("-------------------------------------");
            }
        }

        if (command == "u")
        {
            var updatedauthor = new Author();
            System.Console.WriteLine("Enter Id for updating ! ");
            updatedauthor.Id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter author FirstName : ");
            updatedauthor.FirstName = Console.ReadLine();
            System.Console.Write("Enter author LastName : ");
            updatedauthor.LastName = Console.ReadLine();
            authorservice.UpdateAuthor(updatedauthor);
            System.Console.WriteLine("Author successfully updated ! ");
            System.Console.WriteLine("------------------------------------------");
        }

        if (command == "d")
        {
            System.Console.WriteLine("For deleting Author show Id");
            authorservice.DeleteAuthor(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("Author deleted successfully");
            System.Console.WriteLine("--------------------------------------------");
        }

        if (command == "e")
        {
            break;
        }
    }
}

if (com == "2")
{
    while (true)
    {
        System.Console.WriteLine("c = Create");
        System.Console.WriteLine("r = Read");
        System.Console.WriteLine("u = Update");
        System.Console.WriteLine("d = Delete");
        System.Console.WriteLine("e = Exit");
        System.Console.WriteLine("ba = Search book by Author");
        System.Console.WriteLine("bg = Search book by Genre");

        string command = Console.ReadLine();

        if (command == "c")
        {
            var book = new Books();
            System.Console.Write("Enter book Name : ");
            book.Name = Console.ReadLine();
            System.Console.WriteLine("Book successfully created ! ");
            bookser.AddBook(book);
            System.Console.WriteLine("----------------------------------------");
        }

        if (command == "r")
        {
            foreach (var item in bookser.GetBooks())
            {
                System.Console.WriteLine("Id : " + item.Id);
                System.Console.WriteLine("Name : " + item.Name);
                System.Console.WriteLine("-------------------------------------");
            }
        }

        if (command == "u")
        {
            var updatedbook = new Books();
            System.Console.WriteLine("Enter Id for updating ! ");
            updatedbook.Id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter book Name : ");
            updatedbook.Name = Console.ReadLine();
            bookser.UpdateBook(updatedbook);
            System.Console.WriteLine("Waiting for updating ! ");
            System.Console.Write(".");
            System.Console.Write(".");
            System.Console.WriteLine(".");
            System.Console.WriteLine("Book successfully updated ! ");
            System.Console.WriteLine("------------------------------------------");
        }

        if (command == "d")
        {
            System.Console.WriteLine("For deleting book show Id");
            bookser.DeleteBook(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("Book deleted successfully");
            System.Console.WriteLine("--------------------------------------------");
        }

        if (command == "e")
        {
            break;
        }

        if (command == "ba")
        {
            System.Console.WriteLine("For getting book by author show author Id");
            int a = Convert.ToInt32(Console.ReadLine());
            foreach (var item in bookser.GetBookByAuthorId(a))
            {
                System.Console.WriteLine("Id : " + item.Id);
                System.Console.WriteLine("Name: " + item.Name);
            }
        }

        if (command == "bg")
        {
            System.Console.WriteLine("For getting book by genre show genre Id");
            int a = Convert.ToInt32(Console.ReadLine());
            foreach (var item in bookser.GetBookByGenreId(a))
            {
                System.Console.WriteLine("Id : " + item.Id);
                System.Console.WriteLine("Name: " + item.Name);
            }
        }

    }

}

if (com == "3")
{
    while (true)
    {
        System.Console.WriteLine("c = Create");
        System.Console.WriteLine("r = Read");
        System.Console.WriteLine("u = Update");
        System.Console.WriteLine("d = Delete");
        System.Console.WriteLine("e = Exit");


        string command = Console.ReadLine();

        if (command == "c")
        {
            var genre = new Genre();
            System.Console.Write("Enter genre Name : ");
            genre.GenreName = Console.ReadLine();
            System.Console.WriteLine("genre successfully created ! ");
            genreser.AddGenre(genre);
            System.Console.WriteLine("----------------------------------------");
        }

        if (command == "r")
        {
            foreach (var item in genreser.GetGenre())
            {
                System.Console.WriteLine("Id : " + item.Id);
                System.Console.WriteLine("Name : " + item.GenreName);
                System.Console.WriteLine("-------------------------------------");
            }
        }

        if (command == "u")
        {
            var updatedgenre = new Genre();
            System.Console.WriteLine("Enter Id for updating ! ");
            updatedgenre.Id = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter genre Name : ");
            updatedgenre.GenreName = Console.ReadLine();
            genreser.UpdateGenre(updatedgenre);
            System.Console.WriteLine("genre successfully updated ! ");
            System.Console.WriteLine("------------------------------------------");
        }

        if (command == "d")
        {
            System.Console.WriteLine("For deleting genre show Id");
            genreser.DeleteGenre(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("genre deleted successfully");
            System.Console.WriteLine("--------------------------------------------");
        }

        if (command == "e")
        {
            break;
        }

    }

}