namespace _5_03_pr;

class Program
{
    static void Main(string[] args)
    {
        var registry = new UniversityRegistry();
        
        registry.AddMember(new Professor("Tomas J.", "pr1"));
        registry.AddMember(new UndergraduateStudent("Anna T.", "st1"));
        registry.AddMember(new GraduateStudent("Mike R.", "stg2"));
        
        Console.WriteLine("Chek:");
        registry.ExecuteAllDuties();
        
        Console.WriteLine($"Total actions performed across all members: {registry.GetMemberStatistics()}");

    }
}