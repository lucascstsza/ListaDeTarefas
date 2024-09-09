namespace ListaDeTarefas.Modelos;

public class Tarefa
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public DateOnly Prazo { get; set; }
    public bool Concluida { get; set; }
}
