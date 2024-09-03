
using System.Reflection.Metadata.Ecma335;

Heroes sword = new()
{
    Name = "Artoria",
    AttackDmg = 4,
    Stamina = 30,
    StaminaCost = 3
};

Enemies demonLord = new()
{
    Name = "Diablo",
    AttackDmg = 2,
    Mana = 55,
    ManaCost = 5
};

static void attack(){
    
}

while (true)
{
    Console.WriteLine(demonLord.Name + ": " + sword.Name + " you will never escape forom this place");
    Console.ReadLine();
    Console.WriteLine(demonLord.Name + "Prepare for battle!");

}

