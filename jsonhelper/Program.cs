using System;

namespace jsonhelper
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello World!");
    //     }
    // }

    public class Json_helper
    {
        public Json_helper(string file_path)
        {

            this.filepath = file_path;
        }
        string filepath;
        public string Read_jsonfile()
        {
            return System.IO.File.ReadAllText(filepath);
        }
        public void Write_jsonfile(string value)
        {
            System.IO.File.WriteAllText(filepath, value);
        }

    }

}
