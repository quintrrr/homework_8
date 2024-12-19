namespace files.Class;

public class Project
{
    private string description;
    private DateTime deadline;
    private Person customer;
    private Person teamLead;
    private List<Task> tasks;
    private ProjectStatus status;

    public string Description { get => description; set => description = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public Person Customer { get => customer; private set => customer = value; }
    public Person TeamLead { get => teamLead; set => teamLead = value; }
    public List<Task> Tasks { get => tasks; private set => tasks = value; }
    public ProjectStatus Status { get => status; set => status = value; }
    
    public Project(string description, DateTime deadline, Person customer, Person teamLead)
    {
        Description = description;
        Deadline = deadline;
        Customer = customer;
        TeamLead = teamLead;
        Tasks = new List<Task>();
        Status = ProjectStatus.Проект;
    }

    public Task createTask(string description, DateTime deadline, Person customer)
    {
        if (Status != ProjectStatus.Проект)
        {
            Console.WriteLine("Задачи можно добавлять только в статусе Проект.");
            return null;
        }

        if (teamLead != customer)
        {
            Console.WriteLine("Создавать задачи может только тимлид проекта.");
            return null;
        }
        return new Task(description, deadline, customer);
        
    }

    public void removeTask(ref Task task)
    {
        Tasks.Remove(task);
        task = null;
    }
    
    public void assignTask(Task task, Person executor)
    {
        if (task == null)
        {
            Console.WriteLine("Этой задачи не существует");
            return;
        }
        if (task.Executor != null)
        {
            Console.WriteLine("Эта задача уже назначена");
            return;
        }
        
        task.Executor = executor;
        task.Status = TaskStatus.Назначена;
        if (!Tasks.Contains(task))
        {
            tasks.Add(task);
        }
    }
    
    public void StartProject()
    {
        foreach (var task in Tasks)
        {
            if (task.Executor == null || task.Status != TaskStatus.Назначена)
            {
                Console.WriteLine("Все задачи должны быть назначены перед началом исполнения.");
                return;
            }
        }
        Status = ProjectStatus.Исполнение;
    }

    public void CloseProject()
    {
        foreach (var task in Tasks)
        {
            if (task.Status != TaskStatus.Выполнена)
            {
                Console.WriteLine("Не все задачи выполнены");
            }
        }

        Status = ProjectStatus.Закрыт;
    }
    
    
}