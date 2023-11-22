namespace Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Vad heter person 1.");
                string namn1 = Console.ReadLine();
                Console.WriteLine("Hur gammal är person 1.");
                int age1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Vad heter person 2.");
                string namn2 = Console.ReadLine();
                Console.WriteLine("Hur gammal är person 2.");
                int age2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Vad heter person 3.");
                string namn3 = Console.ReadLine();
                Console.WriteLine("Hur gammal är person 3.");
                int age3 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Vad heeter person 4.");
                string namn4 = Console.ReadLine();
                Console.WriteLine("Hur gammal är person 4.");
                int age4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(namn1 + " är " + age1 + " år gammal ");
                Console.WriteLine(namn2 + " är " + age2 + " år gammal ");
                Console.WriteLine(namn3 + " är " + age3 + " år gammal ");
                Console.WriteLine(namn4 + " är " + age4 + " år gammal ");


                double totalålder = age1 + age2 + age3 + age4;
                Console.WriteLine("Sammanlagda ålder är " + totalålder);
                Console.WriteLine("Medelålder " + totalålder / 4);


            }
        }
}