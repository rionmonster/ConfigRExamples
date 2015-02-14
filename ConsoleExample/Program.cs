using System;
using ConfigR;

namespace ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indicate the file you are using as a Config (along with any related assemblies)
            Config.Global.LoadScriptFile("Application.csx", AppDomain.CurrentDomain.GetAssemblies());

            // Grab your value from the config
            var answer = Config.Global.Get<int>("The Answer to Life, The Universe, and Everything");

            // Output the result
            Console.WriteLine(String.Format("What is the answer to the ultimate question? {0}", answer));

            // Revel in awe at the only answer you'll ever need to know
            Console.Read();
        }
    }
}
