using IniParser;
using IniParser.Model;

namespace console_iniparser_example
{
    internal class Program
    {
        static void Main(string[] _)
        {
            var path = "config.ini";
            var parser = new FileIniDataParser();

            if (!File.Exists(path))
            {
                var defaultConfig = new IniData();
                defaultConfig["size"]["width"] = "50";
                parser.WriteFile(path, defaultConfig);
            }

            var data = parser.ReadFile(path);
            Console.WriteLine(data["size"]["width"]);

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}