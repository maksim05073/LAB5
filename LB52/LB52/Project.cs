namespace LB52;
public class Project
{
    private string NameProject;
    private ProjectType info;
    private DateTime end;
    private double price;
    private Modul[] list;
    public Project(string NameProject,ProjectType info,DateTime end,double price,Modul[] list)
    {
        this.NameProject = NameProject;
        this.info = info;
        this.end = end; 
        this.price = price; 
        this.list = list ?? new Modul[0];
    }
    public override string ToString()
    {
        return "Name"+' '+NameProject+" \ninfo"+' '+info+"\nDateEnd"+' '+end+"\nprice"+' '+price+"\nlist"+' '+list;   
    }
    public string ToShortString()
    {
        double AvgList=0;
        for (int i = 0; i < list.Length; i++)
        {
            AvgList+=list[i].SizeModul;
        }
        AvgList /= list.Length;
        return "Name"+' '+NameProject+" \ninfo"+' '+info+"\nDateEnd"+' '+end+"\nprice"+' '+price+"\nAVGlist"+' '+AvgList;
    }

    public string nameproject
    {
        get => NameProject;
        set => NameProject = value;
    }
    public ProjectType Info
    {
        get => info;
        set => info = value;
    }public DateTime End
    {
        get => end;
        set => end = value;
    }public double Price
    {
        get => price;
        set => Price = value;
    }public Modul[] Name
    {
        get => list;
        set => list = value;
    }

    public double AVGlist
    {
        get
        {
            double AvgList=0;
            for (int i = 0; i < list.Length; i++)
            {
                AvgList+=list[i].SizeModul;
            }
            AvgList /= list.Length;
            return AvgList;
        }
    }

    public bool Index
    {
        get
        {
            bool temp = false;
            for (int i=0;i<)
        }
    }
}