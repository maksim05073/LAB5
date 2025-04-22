namespace LB52;
public enum ProjectType
{
    Commercial,
    Training,
    PersonalUse
}
class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Іван", "Петренко", new DateTime(1995, 4, 10));
        Person p2 = new Person("Марія", "Коваль", new DateTime(1993, 8, 20));

        Modul m1 = new Modul(p1, "База Даних", 4.2);
        Modul m2 = new Modul(p2, "UI/UX", 3.8);

        Project project = new Project("ERP-система", ProjectType.Commercial, DateTime.Now.AddMonths(2), 20000.0, new Modul[] { m1 });

        Console.WriteLine(project.ToShortString());

        Console.WriteLine($"Commercial? {project[ProjectType.Commercial]}");
        Console.WriteLine($"Training? {project[ProjectType.Training]}");
        Console.WriteLine($"PersonalUse? {project[ProjectType.PersonalUse]}");

        project.AddModuls(m2);

        Console.WriteLine("\n=== Детальна інформація ===");
        Console.WriteLine(project.ToString());
        var projects = new[]
        {
            project,
            new Project("Освітній портал", ProjectType.Training, DateTime.Now, 8000.0, new Modul[] { m1, m2 }),
            new Project("Особистий блог", ProjectType.PersonalUse, DateTime.Now.AddDays(5), 500.0, new Modul[] { m2 })
        };

        foreach (var pr in projects)
        {
            Console.WriteLine($"\nКерівники модуля в проєкті \"{pr.Name}\":");
            foreach (var mod in pr.Modules)
            {
                Console.WriteLine(mod.Manager.ToShortString());
            }
        }

        var maxModules = projects.OrderByDescending(p => p.Modules.Length).First();
        Console.WriteLine($"\nПроєкт з найбільшою кількістю модулів: {maxModules.Name}");

        Console.WriteLine("\nПроєкти, що закінчуються цього місяця:");
        foreach (var pr in projects)
        {
            if (pr.EndDate.Month == DateTime.Now.Month && pr.EndDate.Year == DateTime.Now.Year)
            {
                Console.WriteLine(pr.Name);
            }
        }

        Console.ReadKey();
    }
}