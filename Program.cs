using System;

namespace okej
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=20;
            BytPlats (ref a);
            BytPlats (ref b);
            Console.WriteLine(a + " " + b );
        }

        public static void BytPlats(ref int t)
        {
            if(t!=20){
                t=20;
            }
            else if(t!=10){
                t=10;
            }
        }
    }
}
