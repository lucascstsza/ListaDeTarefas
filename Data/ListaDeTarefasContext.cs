using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefas.Data;

public class ListaDeTarefasContext : DbContext
{
    public ListaDeTarefasContext (DbContextOptions<ListaDeTarefasContext> options) : base(options)
    {
    }

    public DbSet<ListaDeTarefas.Modelos.Tarefa> Tarefas { get; set; } = default!;
}
