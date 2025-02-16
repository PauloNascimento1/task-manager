namespace TaskManager;

public class ConsoleManager
{
    List<string> taskList = new List<string>();

    private string optionsMenu = "1 - Criar tarefa \n" +
                                   "2 - Editar tarefa \n" +
                                   "3 - Remover tarefa \n";

    public void InitialMenu()
    {
        Console.WriteLine("Bem-vindo ao gerenciador de tarefas! \n");
        Console.WriteLine(optionsMenu);
        Console.Write("Selecione as opções acima: ");

        SelectingOption();

    }

    private void SelectingOption()
    {
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CreateTask();
            break;
        }

    }

    private void CreateTask()
    {
        Console.Write("\n Adicione uma tarefa: ");

        string task = Console.ReadLine();

        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Insira corretamente a tarefa!");
            SelectingOption();
        }

        taskList.Add(task);
        Console.WriteLine($"\n Tarefa incluída com sucesso! - > {task}");
        SelectingOption();
    }

    private void ShowTasks()
    {

    }
}
