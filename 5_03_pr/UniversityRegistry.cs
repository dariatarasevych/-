namespace _5_03_pr;

public class UniversityRegistry
{
    private List<UniversityMember> _members = new List<UniversityMember>();

    public void AddMember(UniversityMember m) => _members.Add(m);

    public void ExecuteAllDuties()
    {
        foreach (var member in _members)
        {
            member.PerformDuties();
        }
    }

    public int GetMemberStatistics()
    {
        int total = 0;
        foreach (var member in _members)
        {
            total += member.ActionCounter;
        }

        return total;
    }
}