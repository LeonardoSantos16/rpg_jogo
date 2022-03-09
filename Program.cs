using rpg_jogo.src.Entities;
class program
{
    static void Main(string[]args)
    {
        Hero arus = new Hero("Arus", 23, "Knight ");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard ");
        
        Console.Write(wizard.Attack(7));
        Console.Write(arus.Attack());
    }
}