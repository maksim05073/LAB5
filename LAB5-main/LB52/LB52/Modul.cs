namespace LB52;

public class Modul
{
    public Person Manager { get;set;}
    public string NameModul { get; set; }
    public double SizeModul { get; set; }
    public Modul(){}
    public Modul(Person manager, string name, double size)
    {
        Manager = manager;
        NameModul = name;
        SizeModul = size;
    }
    public override string ToString() =>
        $"Manager: {Manager}, Name: {NameModul}, Size: {SizeModul}";
}