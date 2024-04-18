public class Character
{
    public int HealthPoints { get; set; }
    public int level { get; set; }
    public int ExperiencePoints { get; set; }
}

public class Warrior : Character
{
    public int Strength { get; set; }
}
public class Mage : Character
{
    public int MagicPower { get; set; }
}
public class Archer : Character
{
    public int Accuracy { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        Warrior warrior = new Warrior();
        warrior.HealthPoints = 100;
        warrior.level = 1;
        warrior.ExperiencePoints = 0;
        warrior.Strength = 10;

        Console.WriteLine($"Warrior HP: {warrior.HealthPoints}, Level: {warrior.level}, XP: {warrior.ExperiencePoints}, Strength: {warrior.Strength}");

        Mage mage = new Mage();
        mage.HealthPoints = 100;
        mage.level = 1;
        mage.ExperiencePoints = 0;
        mage.MagicPower = 10;

        Console.WriteLine($"Mage HP: {mage.HealthPoints}, Level: {mage.level}, XP: {mage.ExperiencePoints}, Magic Power: {mage.MagicPower}");

        Archer archer = new Archer();
        archer.HealthPoints = 100;
        archer.level = 1;
        archer.ExperiencePoints = 0;
        archer.Accuracy = 10;

        Console.WriteLine($"Archer HP: {archer.HealthPoints}, Level: {archer.level}, XP: {archer.ExperiencePoints}, Accuracy: {archer.Accuracy}");
    }
}