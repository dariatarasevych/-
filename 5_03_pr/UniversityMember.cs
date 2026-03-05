namespace _5_03_pr;

public class UniversityMember
{
    private string _name;
    
    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? throw new Exception("Invalid name") : value;
    }
    
    public string MemberId { get;  }

    protected List<string> ActionLog = new List<string>();
    protected bool Reach5Actions { get; set; }

    public UniversityMember(string name, string memberId)
    {
        Name = name;
        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        Reach5Actions = true;
        throw new Exception("You have already reached a daily limit of 5 actions");
    }
}