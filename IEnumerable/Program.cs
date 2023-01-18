using System.Linq;

static void Main(string[] args)
{
    List<Employee> employees = new List<Employee>()
    {
        new Employee() { Id = 1, name = "Jalol" },
        new Employee() { Id = 2, name = "Rahmatov" }
    };

    IEnumerable<Employee> query = from emp in employees
                                  where emp.Id == 1
                                  select emp;

    foreach (var item in employees)
    {
        Console.WriteLine($"Id={item.Id} Name={item.name}");
    }

    //IQuerable
    List<Employee> employees1 = new List<Employee>()
    {
         new Employee() { Id = 1, name = "Jalol" },
        new Employee() { Id = 2, name = "Rahmatov" }
    };

    IQueryable<Employee> query2 = employees1.AsQueryable().Where(x => x.Id == 2);

    foreach (var item in employees1)
    {
        Console.WriteLine($"Id={item.Id} Name={item.name}");
    }
}