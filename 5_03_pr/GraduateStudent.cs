namespace _5_03_pr;

public class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent (string name, string memberId) : base(name, memberId) {}
    public override void PerformDuties()
    {
        base.PerformDuties();
        string info = $"Thesis research update by {Name}, ID: {MemberId}";
        ActionLog.Add("Thesis research update");
        Console.WriteLine(info);
    }
}