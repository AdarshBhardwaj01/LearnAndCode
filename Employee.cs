public class Employee
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Department { get; private set; }
    private bool working;

    public Employee(int id, string name, string department, bool working = true)
    {
        Id = id;
        Name = name;
        Department = department;
        this.working = working;
    }

    public bool IsWorking() => working;

    public void Terminate() => working = false;
}

// Persistence layer
public class EmployeeRepository
{
    public void Save(Employee employee)
    {
        Console.WriteLine($"Saving employee {employee.Name} to database.");
    }
}

// Reporting layer
public class EmployeeReportService
{
    public void PrintCSV(Employee employee)
    {
        Console.WriteLine($"{employee.Id},{employee.Name},{employee.Department},{(employee.IsWorking() ? "Working" : "Terminated")}");
    }

    public void PrintXML(Employee employee)
    {
        Console.WriteLine($"<Employee>\n" +
                          $"  <ID>{employee.Id}</ID>\n" +
                          $"  <Status>{(employee.IsWorking() ? "Working" : "Terminated")}</Status>\n" +
                          $"</Employee>");
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp = new Employee(101, "John Doe", "IT");

        var repository = new EmployeeRepository();
        var reportService = new EmployeeReportService();

        repository.Save(emp);
        reportService.PrintCSV(emp);
        reportService.PrintXML(emp);

        emp.Terminate();
        Console.WriteLine($"Is working? {emp.IsWorking()}");
    }
}
