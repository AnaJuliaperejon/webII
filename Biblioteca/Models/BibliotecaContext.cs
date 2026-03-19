namespace Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

public class BibliotecaContext : DbContext
{
public BibliotecaContext(DbContextOptions options)
: base(options)
{
}
public DbSet<Livro> Livros { get; set; }
}
