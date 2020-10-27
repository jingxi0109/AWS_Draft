using System;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //        object class1 = AWSModel.Class1;
            //    AWSModel.Class1 class1=new AWSModel.Class1();
            //   AWSModel.Class1 class1 = new AWSModel.Class1();
            // Console.WriteLine(class1.name);
            AWSModel.Userinfo userinfo = new AWSModel.Userinfo()
            {
                Name = "newName",
                GUUID = "2233322233",
                Phone = "13222330099"
            };
            userinfo.Save_info();
            System.Threading.Thread.Sleep(1000);
           var res = userinfo.Load_info();
           res.Phone = "13333333333";
           res.Save_info();
            Console.WriteLine("done.");

        }
    }
}
