namespace HomeWork;

public abstract class Build
{
    private string name = "";

    public Build(string name)
    {
        this.name = name;
    }
    public void setName(string name) => this.name = name;
    public string getName() => this.name;
}