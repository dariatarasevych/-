namespace _5_03_pr;

public class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent (string name, string memberId) : base(name, memberId) {}
    public override void PerformDuties()
    {
        base.PerformDuties();
        Console.WriteLine("Thesis research update");
    }
}