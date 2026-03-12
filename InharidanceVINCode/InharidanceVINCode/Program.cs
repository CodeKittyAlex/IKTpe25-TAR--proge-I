namespace InharidanceVINCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta vin kood:");
            int vinCode = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.setVinCode(vinCode);

            Console.WriteLine("vin code is: " + machine.GetvinCode);

        }
    }
    internal class Cars
    {
        public void setVinCode(int vinCode)
        {
            vin = vinCode;
        }
        protected int vin;
    }
    internal class Machine : Cars
    {
        public int GetvinCode()
        {
            return vin;
        }
    }
}
