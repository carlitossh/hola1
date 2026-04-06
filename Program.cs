using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Emit;
enum Category {Work, Personal, Shopping}

public class Task
{
    public int id;
    public required string Title {set; get; }
    public required string Description {set; get; }
    public required string Categoria {set; get;}
    
    public override string ToString()
    {
        return $"ID: {id}, Nombre: {Title}, Descripcion: {Description}, Categoría: {Categoria}";
    }
}


class MenuSystem
{
  List <Task> tasks = new List<Task>();
    int numtasks=0;
    static void MostrarMenu()
    {
        Console.WriteLine("Menu!");

    }
    static void sel(int opc, MenuSystem op)
    {

        switch (opc)
        {
            case 1:
            Console.WriteLine("nombre de la tarea");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("descripcion de la tarea");
            string descripcion = Console.ReadLine() ?? "";
            Console.WriteLine("Categoría de la tarea");
            string Categoria = Console.ReadLine() ?? "";
            Task tarea = new Task{Title=nombre, Description=descripcion, Categoria=Categoria};
            op.addTask(tarea);
            break;
            case 2:
            op.viewallTasks();
            break;
            case 3:
            Console.WriteLine("Categoría a buscar:\n");
            string Cate = Console.ReadLine() ?? "";
            op.viewallTasksCategory(Cate);
            break;
            case 4:
            Console.WriteLine("id de la tarea a eliminar:\n");
            int id = Convert.ToInt16 (Console.ReadLine());
            op.DeleteTask(id);
            break;
            default:
            Console.WriteLine("elige una opcion valida");
            break;

        }


    }
    public void DeleteTask(int id)
    {
        int k=0;
        this.tasks.RemoveAt(id);
        numtasks-=1;
        foreach (Task i in this.tasks)
        {
            i.id = k++;
        }
        
    }
    public void addTask(Task task)
    {
        task.id=numtasks;
        this.tasks.Add(task);
        numtasks+=1;
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
        MenuSystem op = new MenuSystem();
        int opc= 0;
        do
        {
            MenuSystem.MostrarMenu();
            opc =  Convert.ToInt16 (Console.ReadLine());
            MenuSystem.sel(opc, op);
        }
        while (opc != 5);
        
        
    }
}