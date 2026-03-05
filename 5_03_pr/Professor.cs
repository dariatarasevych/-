namespace _5_03_pr;

public class Professor : UniversityMember
{
    public Professor(string name, string memberId) : base(name, memberId) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        string info = $"Lecture delivered by {Name}, ID: {MemberId}";
        ActionLog.Add("Lecture delivered");
        Console.WriteLine(info);
    }

    public string ConductResearch(string topic)
    {
        return topic;
    }
}