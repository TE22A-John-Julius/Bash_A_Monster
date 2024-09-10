
using System.Reflection.Metadata.Ecma335;

Heroes sword = new()
{
    Name = "Artoria",
    AttackDmg = 4,
    Stamina = 30,
    StaminaCost = 3,
    Hp = 100
};

Enemies demonLord = new()
{
    Name = "Diablo",
    AttackDmg = 2,
    Mana = 55,
    ManaCost = 5,
    Hp = 56
};

void PlayerAttack()
{
    demonLord.Hp -= sword.AttackDmg;
    sword.Stamina -= sword.StaminaCost;
}

Console.WriteLine($"{demonLord.Name}: {sword.Name} you will never escape forom this place");
Console.ReadLine();
Console.WriteLine($"{demonLord.Name}: Prepare for battle!");
while (true)
{
    Random hitChance = new Random();
    int hit = hitChance.Next(1,11);
    Console.WriteLine($"{demonLord.Hp}     /VS/     {sword.Hp}");
    Console.WriteLine("If you would like to attack press 1, if you want to block press 2");
    string choice = Console.ReadLine();
    if (choice == "1"){
        if (hit <= 5){
            PlayerAttack();
            Console.Writeline
        }
        else{
            Console.WriteLine("Your attack did not suceed");
        }
    }
    else if(choice == "2"){
        if (hit >= 5){
            Console.WriteLine("You sucessfully blocked the incoming attack");
        }
        else {
            
        }
    }
}

