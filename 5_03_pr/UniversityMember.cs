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

    public UniversityMember(string name, string memberId)
    {
        _name = name;
        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        
    }
}