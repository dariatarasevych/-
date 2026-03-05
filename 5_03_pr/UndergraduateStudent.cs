namespace _5_03_pr;

public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name, string memberId) : base(name, memberId) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lab work completed");
        Console.WriteLine("Lab work completed");
    }
}