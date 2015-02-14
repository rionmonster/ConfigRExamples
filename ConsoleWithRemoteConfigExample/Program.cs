using System;
using ConfigR;

namespace ConsoleWithRemoteConfigExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indicate the file you are using as a Config (along with any related assemblies)
            Config.Global.LoadWebScript(new Uri("https://gist.githubusercontent.com/Rionmonster/21e70f6bbb93638a694a/raw/041b0f0c88b6e5f881a5fd1ee5b1af97ac021b48/RemoteConfig.csx"), AppDomain.CurrentDomain.GetAssemblies());

            // Grab your value from the config
            var answer = Config.Global.Get<string>("Word");

            // Output the result
            Console.WriteLine(String.Format("What is the word? {0}", answer));

            // Revel in awe at the only answer you'll ever need to know
            Console.Read();
        }
    }
}
