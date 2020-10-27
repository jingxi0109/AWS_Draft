using System;
using AWSModel;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // AWSModel.Userinfo userinfo = new AWSModel.Userinfo()
            // {
            //     Name = "newName",
            //     GUUID = "2233322233",
            //     Phone = "13222330099"
            // };
            UserCollection uc = UserCollection.Load_info();


            // uc.Add(userinfo);
            // uc.Add(userinfo);
            // uc.Add(userinfo);
            // uc.Add(userinfo);
            // uc.Add(userinfo);
            // uc.Add(userinfo);
            // uc.Save_info();
            // Console.WriteLine("save done.");
            // var res = uc.Load_info();
            // Console.WriteLine(res.has_user("2233322233"));
            Console.WriteLine(uc.Count);
        }
    }
}
