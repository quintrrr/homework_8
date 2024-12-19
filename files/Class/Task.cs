namespace files.Class;

public class Task
{
    private string description;
    private DateTime deadline;
    private Person customer;
    private Person executor;
    private TaskStatus status;
    private Report report;

    public string Description { get => description; set => description = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public Person Customer { get => customer; private set => customer = value; }
    public Person Executor { get => executor; set => executor = value; }
    public TaskStatus Status { get => status; set => status = value; }
    public Report Report { get => report; set => report = value; }
    
    public Task(string description, DateTime deadline, Person customer)
    {
        Description = description;
        Deadline = deadline;
        Customer = customer;
    }

    public void AcceptTask()
    {
        Status = TaskStatus.ВРаботе;
    }
    
    public void DelegateTask(Person newExecutor)
    {
        Executor = newExecutor;
        Status = TaskStatus.Назначена;
    }

    public void RejectTask()
    {
        Executor = null;
        Status = TaskStatus.Назначена;
    }

    public void SubmitReport(string text)
    {
        Report = new Report(text, DateTime.Now, Executor);
        Status = TaskStatus.НаПроверке;
    }
    
    public void ApproveReport()
    {
        if (Status != TaskStatus.НаПроверке) Console.WriteLine("Отчёт не на проверке.");
        Status = TaskStatus.Выполнена;
    }

    public void RequestRevision()
    {
        if (Status != TaskStatus.НаПроверке) Console.WriteLine("Отчёт не на проверке.");
        Status = TaskStatus.ВРаботе;
    }
}