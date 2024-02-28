namespace Infrastructure;
using Npgsql;
using Dapper;
using Domain;

public class GenreServices
{
    private string _connectionstring = 
    "Server=localhost;Port=5432;Database=EducationDb;User Id = postgres;Password=2007";
    
    public List<Genre> GetGenre()
    {
        using var connection = new NpgsqlConnection (_connectionstring);
        var result = connection.Query<Genre>("select * from genre").ToList();
        return result;
    }

    public void AddGenre(Genre genre)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("insert into genre (genrename) values (@genrename)",genre);
    }

    public void UpdateGenre(Genre genre)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("update genre set genrename = @genrename where id = @id",genre);
    }

    public void DeleteGenre(int id)
    {
        using var connection = new NpgsqlConnection(_connectionstring);
        connection.Execute("delete from genre where id = @id",new { Id = @id });
    }

}

