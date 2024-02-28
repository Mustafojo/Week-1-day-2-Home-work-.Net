namespace Infrastructure;
using Domain.Models;
using Npgsql;
using Dapper;


public class BookServices
{
    private string _connectionstring = 
    "Server=localhost;Port=5432;Database=EducationDb;User Id = postgres;Password=2007";
    
    public List<Books> GetBooks()
    {
        using var connection = new NpgsqlConnection (_connectionstring);
        var result = connection.Query<Books>("select * from books").ToList();
        return result;
    }

    public void AddBook(Books book)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("insert into books (name) values (@name)",book);
    }

    public void UpdateBook(Books book)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("update books set name = @name,author = @author where id = @id",book);
    }

    public void DeleteBook(int id)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("delete from books where id = @id",new { Id = @id });
    }

      public List<Books> GetBookByAuthorId(int id)
    {
        using var connection = new NpgsqlConnection (_connectionstring);
        var result = connection.Query<Books>("select ab.AuthorId,a.FirstName,a.LastName,b.Name from AuthorBook as ab join Author as a on a.Id = ab.AuthorId join Books as b on b.Id = ab.BookId where id = @id" , new { Id = id}).ToList();
        return result;
    }

       public List<Books> GetBookByGenreId(int id)
    {
        using var connection = new NpgsqlConnection (_connectionstring);
        var result = connection.Query<Books>("select gb.GenreId,g.genrename as Genrename,b.Name as BookName from GenreBook as gb join Genre as g on g.Id = gb.GenreId join Books as b on b.Id = gb.BookId" , new { Id = id}).ToList();
        return result;
    }

}