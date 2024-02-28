namespace Infrastructure;
using Domain.Models;
using Npgsql;
using Dapper;
using Domain;

public class AuthorServices
{
    private string _connectionstring = 
    "Server=localhost;Port=5432;Database=EducationDb;User Id = postgres;Password=2007";
    
    public List<Author> GetAuthor()
    {
        using var connection = new NpgsqlConnection (_connectionstring);
        var result = connection.Query<Author>("select * from author").ToList();
        return result;
    }

    public void AddAuthor(Author author)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("insert into author (FirstName,LastName) values (@FirstName,@LastName)",author);
    }

    public void UpdateAuthor(Author author)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("update author set firstname = @firstname,lastname = @lastname where id = @id",author);
    }

    public void DeleteAuthor(int id)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("delete from author where id = @id",new { Id = @id });
    }

  
}

