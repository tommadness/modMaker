using System;
using System.IO;

namespace modMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("mod", "*.*", SearchOption.AllDirectories);
            var output = "assets:\r";
            foreach (var file in files)
            {
                output += String.Format("- name: {0}\r  method: copy\r  source:\r  - name: {0}\r", file.Remove(0,4));
            }
            File.WriteAllText("mod/OUTPUTmod.yml", output);
        }
    }
}
