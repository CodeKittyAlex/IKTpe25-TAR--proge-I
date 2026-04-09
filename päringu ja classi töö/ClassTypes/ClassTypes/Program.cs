namespace ClassTypes
{
    //kas see peaks olema internal
    //ei
    internal class GameObject
    {
        public string Name;

        public virtual void Spawn()
        {
            Console.WriteLine(Name + " spawn");
        }
        public virtual void Move()
        {
            Console.WriteLine(Name + " is moving");
        }
    }
    //kas private sobib siia
    //ei
    //private class Player : GameObject
    class Player : GameObject
    {
        public override void Spawn()
        {
            Console.WriteLine(Name + " spawn");
        }
        public override void Move()
        {
            Console.WriteLine(Name + " is moving");
        }

    }
    //kas protected sobib siia
    //ei
    //protected class Enemy : GameObject
    class Enemy : GameObject
    {
        public void Attack()
        {
            Console.WriteLine(Name + " attacks");
        }
        public override void Spawn()
        {
            Console.WriteLine(Name + " spawn");
        }
        public override void Move()
        {
            Console.WriteLine(Name + " is moving");
        }
    }
    //kas sealed on õigesti kasutatud?
    //jah
    sealed class Boss : Enemy
    {
        public void SpecialAttack()
        {
            Console.WriteLine(Name + " uses special attack");
        }
        public override void Spawn()
        {
            Console.WriteLine(Name + " spawn");
        }
        public override void Move()
        {
            Console.WriteLine(Name + " is moving");
        }
    }
    //Kas privaatne klass töötab siin
    //ei
    //private class GameHelper
    public class GameHelper
    {
        public static void Help()
        {
            Console.WriteLine("helping game");
        }
    }
    class program
    {
        //Player p = new Player();
        GameObject p = new Player();
        p.Name = "Hero";
        p.Spawn();
        p.Move();

        GameObject e = new Enemy();
        e.Name = "Goblin";
        e.spawn();
        e.Move();

        GameObject b = new Boss();
        b.Name = "Dragon";
        b.spawn();
        b.Move();


        GameHelper;
    }
}