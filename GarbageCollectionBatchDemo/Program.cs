using System.Net.Sockets;

namespace GarbageCollectionBatchDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------Garbage collection for int array------------");
            long num1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];
                values = null;
            }
            long num2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long num3 = GC.GetTotalMemory(true);
            {
                Console.WriteLine("num1 "+num1);
                Console.WriteLine("num2 "+num2);
                Console.WriteLine("num3 "+num3);
            }
            Console.WriteLine("---------Garbage collection for byte array------------");

            long byte1 = GC.GetTotalMemory(false);
            byte[] memory = new byte[1000*100*10];
            long byte2 = GC.GetTotalMemory(false);
            long byte3 = GC.GetTotalMemory(true);

            Console.WriteLine(byte1);
            Console.WriteLine(byte2);
            Console.WriteLine("different of byte2-byte1");
            Console.WriteLine(byte2-byte1);

            Console.WriteLine(byte3);
            Console.WriteLine("different of byte3-byte2");
            Console.WriteLine(byte3-byte2);

            Console.ReadLine();
        }
    }
}
