namespace files.Class;

public class Report
{
    private string text;
    private DateTime deadline;
    private Person customer;
    
    public string Text { get => text; set => text = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public Person Customer { get => customer; private set => customer = value; }

    public Report(string text, DateTime deadline, Person customer)
    {
        Text = text;
        Deadline = deadline;
        Customer = customer;
    }
    
}