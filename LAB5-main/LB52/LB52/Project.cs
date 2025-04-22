using LB52;

namespace LB52 
{
public class Project
    {
        private string name;
        private ProjectType type;
        private DateTime endDate;
        private double price;
        private Modul[] modules;

        public Project(string name, ProjectType type, DateTime endDate, double price, Modul[] modules)
        {
            Name = name;
            Type = type;
            EndDate = endDate;
            Price = price;
            Modules = modules ?? new Modul[0];
        }

        public Project() : this("Unnamed", ProjectType.PersonalUse, DateTime.Now, 0.0, new Modul[0]) { }

        public string Name
        {
            get => name;
            set => name = value ?? "Unnamed";
        }

        public ProjectType Type
        {
            get => type;
            set => type = value;
        }

        public DateTime EndDate
        {
            get => endDate;
            set => endDate = value;
        }

        public double Price
        {
            get => price;
            set
            {
                if (value < 0) throw new ArgumentException("Price cannot be negative");
                price = value;
            }
        }

        public Modul[] Modules
        {
            get => modules;
            set => modules = value ?? new Modul[0];
        }

        public double AverageModuleSize => modules.Length > 0 ? modules.Average(m => m.SizeModul) : 0;

        public bool this[ProjectType pt] => type == pt;

        public void AddModuls(params Modul[] newModules)
        {
            modules = modules.Concat(newModules).ToArray();
        }

        public override string ToString()
        {
            string moduleList = string.Join("\n", modules.Select(m => m.ToString()));
            return $"Project: {Name}\nType: {Type}\nEnd Date: {EndDate.ToShortDateString()}\nPrice: {Price}\nAverage Module Size: {AverageModuleSize:F2}\nModules:\n{moduleList}";
        }

        public string ToShortString()
        {
            return $"Project: {Name}\nType: {Type}\nEnd Date: {EndDate.ToShortDateString()}\nPrice: {Price}\nAverage Module Size: {AverageModuleSize:F2}";
        }
    }
}
