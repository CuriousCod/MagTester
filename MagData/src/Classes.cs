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
        None,
        Male,
        Female
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

