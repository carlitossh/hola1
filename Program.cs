using System.Linq.Expressions;
using System.Reflection.Emit;

public class Task
{
    public required string Title {set; get; }
    public required string Description {set; get; }
    enum Category {Work, Personal, Shopping}
    public required string Categoria {set; get;}
}
class MenuSystem
{
    Task [] tasks = new Task[5];
    int numtasks=0;
    static void MostrarMenu()
    {
        Console.WriteLine("Menu!");

    }
    static void sel(int opc)
    {
        switch (opc)
        {
            case 1:
            MenuSystem op = new MenuSystem();
            Console.WriteLine("nombre de la tarea");
            string nombre = Console.ReadLine();
            Console.WriteLine("nombre de la tarea");
            Console.WriteLine("nombre de la tarea");
            Console.WriteLine("nombre de la tarea");
            Task tarea = new Task{Title=nombre};

            op.addTask(Task);
            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
            default:
            Console.WriteLine("elige una opcion valida");
            break;

        }


    }
    public void addTask(Task tasks)
    {
        this.tasks[numtasks]=tasks;
    }
    void viewallTasks()
    {
        foreach (var task in this.tasks)
        {
            Console.WriteLine(task);
        }
    }
    void viewallTasksCategory(string Categoria)
    {
                foreach (var task in this.tasks)
        {
            if(task.Categoria == Categoria )
            Console.WriteLine(task);
        }
    }

    static void Main(string[] args)
    {
        int opc= 0;
        do
        {
            MenuSystem.MostrarMenu();

        }
        while (opc != 5);
        
        
    }
}