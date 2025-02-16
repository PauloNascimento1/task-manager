namespace TaskManager;

public class ConsoleManager
{
    List<string> taskList = new List<string>();
    Utils utils = new Utils();

    private string optionsMenu = "\n1 - Criar tarefa\n" +
                                   "2 - Mostrar tarefas\n" +
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

        string task = Console.ReadLine();

        if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Insira corretamente a tarefa!");
            InitialMenu();
        }

        taskList.Add(task);
        Console.WriteLine($"\nTarefa incluída com sucesso! -> '{task}'");

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
            Console.WriteLine($"{i} - {taskList[i - 1]}");
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
            Console.WriteLine($"{i} - {taskList[i - 1]}");
        }

        Console.Write("\nSelecione uma tarefa para remover passando o número exibido: ");
        int optionForDelete = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nRemovendo a tarefa -> '{taskList[optionForDelete - 1]}'");
        taskList.Remove(taskList[optionForDelete - 1]);
 
        utils.ClearConsole();
        InitialMenu();


    }
}
