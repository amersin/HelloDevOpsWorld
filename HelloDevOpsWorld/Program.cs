using System;

namespace HelloDevOpsWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = string.Empty;

            if (args.Length > 1)
                name = args[1];

            Console.WriteLine("Hello DevOps World!" + name);
        }
    }
}
