namespace inheridence2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("inheritance 2");

            //kui siin on water class, siis kuvataks seal olevat DoSomething meetodi sisu
            //kui panna water water = new river(); , siis kuvatakse river classis olevat DoSomething
            water water = new water();
            water water2 = new river();
            water.flow = true;
            water.Length = "123";

            water water3 = new lake();
            water.flow = false;
            water.Length = "123";
            //river river = new river();
            //river.riverMethod();
            //kutsume soovitud meetodi esile
            water.DoSomenthing();
            water2.DoSomenthing();
            water3.DoSomenthing();
        }
    }
}
