
public record Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class EmployeeClass
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public EmployeeClass(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override bool Equals(object obj)
    {
        if (obj is EmployeeClass otherEmployee)
        {
            return FirstName == otherEmployee.FirstName && LastName == otherEmployee.LastName;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("C# Records Demo");

        Employee emp1 = new Employee("John", "Doe");
        Console.WriteLine($"Employee 1 : {emp1.FirstName} {emp1.LastName}");

        //    Employee emp2 = emp1 with { LastName = "Smith" };
        Employee emp2 = new Employee("John", "Doe");
        Console.WriteLine($"Employee 2 : {emp2.FirstName} {emp2.LastName}");

        if(emp1 ==  emp2)
        {
            Console.WriteLine("emp1 and emp2 are equal.");
        }
        else
        {
            Console.WriteLine("emp1 and emp2 are not equal.");
        }

        // class equality checks 

        EmployeeClass empcls1 = new EmployeeClass("John", "Doe");
        Console.WriteLine($"EmployeeClass 1 : {emp1.FirstName} {emp1.LastName}");

        //    EmployeeClass empcls2 = emp1 with { LastName = "Smith" };
        EmployeeClass empcls2 = new EmployeeClass("John", "Doe");

        Console.WriteLine($"EmployeeClass 2 : {emp2.FirstName} {emp2.LastName}");

       
         if (empcls1.Equals(empcls2))
        {
            Console.WriteLine("emp1 and emp2 are equal.");
        }
        else
        {
            Console.WriteLine("emp1 and emp2 are not equal.");
        }
    }
}