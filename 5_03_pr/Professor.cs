namespace _5_03_pr;

public class Professor : UniversityMember
{
    public Professor(string name, string memberId) : base(name, memberId) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        Console.WriteLine("Lecture delivered");
    }

    public string ConductResearch(string topic)
    {
        return topic;
    }
}