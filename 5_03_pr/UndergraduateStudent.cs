namespace _5_03_pr;

public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string memberId) : base(name, memberId) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        string info = $"Lab work completed by {Name}, ID: {MemberId}";
        ActionLog.Add("Lab work completed");
        Console.WriteLine(info);
    }
}