namespace MagData;

public class PlayerCharacter
{
    public Genders Gender = Genders.None;
    public Classes Class = Classes.None;
    public SectionIDs SectionId = SectionIDs.None;
    public int Level = 1;

    public PlayerCharacter(){}

    public PlayerCharacter(Classes playerClass)
    {
        Class = playerClass;
    }

    public PlayerCharacter(Classes playerClass, Genders playerGender)
    {
        Class = playerClass;
        Gender = playerGender;
    }

    public PlayerCharacter(Classes playerClass, SectionIDs playerSectionId)
    {
        Class = playerClass;
        SectionId = playerSectionId;
    }

    public PlayerCharacter(Classes playerClass, Genders playerGender, SectionIDs playerSectionId)
    {
        Gender = playerGender;
        Class = playerClass;
        SectionId = playerSectionId;
    }

    public enum Classes
    {
        None = -1,
        Hunter = 0,
        Ranger = 1,
        Force = 2
    }

    public enum Genders
    {
        None = -1,
        Male,
        Female
    }

    public static List<string> GetClassNames()
    {
        var classNames = Enum.GetNames(typeof(PlayerCharacter.Classes));

        classNames = classNames.Take(classNames.Length - 1).ToArray();

        return classNames.ToList();
    }

    public static List<string> GetGenderNames()
    {
        var genderNames = Enum.GetNames(typeof(PlayerCharacter.Genders));

        genderNames = genderNames.Take(genderNames.Length - 1).ToArray();

        return genderNames.ToList();
    }

    public static List<string> GetSectionIdNames()
    {
        var sectionIdNames = Enum.GetNames(typeof(SectionIDs));

        sectionIdNames = sectionIdNames.Take(sectionIdNames.Length - 1).ToArray();

        return sectionIdNames.ToList();
    }
}

public enum SectionIDs
{
    None = -1,
    Viridia = 0,
    Greenill = 1,
    Skyly = 2,
    Bluefull = 3,
    Purplenum = 4,
    Pinkal = 5,
    Redria = 6,
    Oran = 7,
    Yellowboze = 8,
    Whitill = 9
}

