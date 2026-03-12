namespace Inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert 2 numbers: ");
            Console.WriteLine("first number: ");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("second number: ");
            int secondNr = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.setWith(firstNr);
            rectangle.setHeight(secondNr);

            Console.WriteLine("Total area {0}", rectangle.GetArea());
        }
    }

    class Shape
    {
        public void setWith(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }
    //koolon tähendab päringut
    // läbi pärimise saame kasutada muutujaid with ja height, mis asuvad Shape classis
    //ning neid ei pea siis defineerima Rectangle classis
    class Rectangle : Shape
    {
        public int GetArea()
        { 
            //return tagastab info selles meetodis toimunud loogika kohta
            return (width * height);
        }
    }
}
