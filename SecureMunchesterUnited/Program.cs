﻿
// https://exercism.org/tracks/csharp/exercises/secure-munchester-united/edit


SecurityPassMaker spm = new SecurityPassMaker();

Console.WriteLine(spm.GetDisplayName(new Manager()));
Console.ReadLine();

Console.WriteLine(spm.GetDisplayName(new Physio()));
Console.ReadLine();

Console.WriteLine(spm.GetDisplayName(new GoalKeepingCoach()));
Console.ReadLine();

Console.WriteLine(spm.GetDisplayName(new OffensiveCoach()));
Console.ReadLine();

Console.WriteLine(spm.GetDisplayName(new SecurityJunior()));
Console.ReadLine();

Console.WriteLine(spm.GetDisplayName(new OffensiveCoach()));
Console.ReadLine();

Console.WriteLine(spm.GetDisplayName(new Chairman()));
Console.ReadLine();


public class SecurityPassMaker
{
    public string GetDisplayName(TeamSupport support)
    {
        if (support is not Staff)
        {
            return "Too Important for a Security Pass";
        }

        if (support.GetType() == typeof(SecurityJunior) ||
            support.GetType() == typeof(SecurityIntern) ||
            support.GetType() == typeof(PoliceLiaison))
        {
            return support.Title;
        }

        if (support is Security)
        {
            return support.Title + " Priority Personnel";
        }
        return support.Title;
    }
}

/**** Please do not alter the code below ****/

public interface TeamSupport { string Title { get; } }

public abstract class Staff : TeamSupport { public abstract string Title { get; } }

public class Manager : TeamSupport { public string Title { get; } = "The Manager"; }

public class Chairman : TeamSupport { public string Title { get; } = "The Chairman"; }

public class Physio : Staff { public override string Title { get; } = "The Physio"; }

public class OffensiveCoach : Staff { public override string Title { get; } = "Offensive Coach"; }

public class GoalKeepingCoach : Staff { public override string Title { get; } = "Goal Keeping Coach"; }

public class Security : Staff { public override string Title { get; } = "Security Team Member"; }

public class SecurityJunior : Security { public override string Title { get; } = "Security Junior"; }

public class SecurityIntern : Security { public override string Title { get; } = "Security Intern"; }

public class PoliceLiaison : Security { public override string Title { get; } = "Police Liaison Officer"; }
