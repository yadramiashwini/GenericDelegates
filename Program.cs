namespace GenericDelegates
{
    public class Program
    {
        public static int Value(int x, int y, int z)
        {
            return x + y + z;
        }
        public static void Mul(int x, int y, int z)
        {
            Console.WriteLine("multiplication is:"+x*y*z);
        }
        public static bool Print(string name)
        {
            if (name.Length > 7)
            {
                return true;

            }
            return false;
        }

        static void Main(string[] args)
        {
            Func<int, int, int, int> func_1 = new Func<int, int, int, int>(Value);

            Action<int,int,int> act_1 = new Action<int, int, int>(Mul);

            Predicate<string> ped_1 = new Predicate<string>(Print);

            int value = func_1.Invoke(10, 20, 30);
            Console.WriteLine("sum is:"+value);
            act_1.Invoke(10, 20, 30);
            bool val = ped_1.Invoke("Ashwini");
            Console.WriteLine(val);
           
        }
    }
}
