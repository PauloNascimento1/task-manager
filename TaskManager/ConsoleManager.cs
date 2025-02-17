namespace TaskManager;

public class ConsoleManager
{
    public int TaskId { get; set; }
    public string? Description { get; set; }
    public DateTime CreationTime { get; set; } = DateTime.Now.ToLocalTime();

    List<TaskItem> taskList = new List<TaskItem>();
    Utils utils = new Utils();

    private string optionsMenu = "\n1 - Criar tarefa\n" +
                                   "2 - Exibir tarefas\n" +
                                   "3 - Remover tarefa\n";

    public void InitialMenu()
    {
        Console.WriteLine(optionsMenu);
        Console.Write("Selecione as opções acima: ");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                CreateTask();
                break;
            case 2:
                ShowTask();
                break;
            case 3:
                RemoveTask();
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }
    }

    private void CreateTask()
    {
        Console.Write("\nAdicione uma tarefa: ");

        string taskDescription = Console.ReadLine();

        if (string.IsNullOrEmpty(taskDescription))
        {
            Console.WriteLine("Insira corretamente a tarefa!");
            InitialMenu();
        }

        var newTask = new TaskItem
        {
            TaskId = taskList.Count + 1,
            Description = taskDescription
        };

        taskList.Add(newTask);

        Console.WriteLine($"\nTarefa incluída com sucesso! -> '{newTask.Description}', \nData de criação: '{newTask.CreationTime}'");

        utils.ClearConsole();
        InitialMenu();
    }

    private void ShowTask()
    {
        Console.WriteLine("\nMostrando tarefas:\n");

        if (taskList.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa encontrada...Voltando para o menu!");

            utils.ClearConsole();
            InitialMenu();
        }

        for (int i = 1; i <= taskList.Count; i++)
        {
            Console.WriteLine($"{i} - '{taskList[i - 1].Description}', Data de criação: '{taskList[i - 1].CreationTime}'");
        }

        utils.ClearConsole();
        InitialMenu();
    }

    private void RemoveTask()
    {
        Console.WriteLine("\nMostrando tarefas::\n");

        if (taskList.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa encontrada para remover...Voltando para o menu!");

            utils.ClearConsole();
            InitialMenu();
        }

        for (int i = 1; i <= taskList.Count; i++)
        {
            Console.WriteLine($"{i} - '{taskList[i - 1].Description}', Data de criação: '{taskList[i - 1].CreationTime}'");
        }

        Console.Write("\nSelecione uma tarefa para remover passando o número exibido: ");
        int optionForDelete = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nRemovendo a tarefa -> '{taskList[optionForDelete - 1].Description}, \nData de criação: {taskList[optionForDelete - 1].CreationTime}'...");
        taskList.Remove(taskList[optionForDelete - 1]);

        utils.ClearConsole();
        InitialMenu();

    }
}
