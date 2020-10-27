﻿using System;
using System.Collections.Generic;

namespace AWSModel
{
    public class Userinfo
    {
        static jsonhelper.Json_helper js=new jsonhelper.Json_helper(@"./user.json");
        public string Name { get; set; }    
        public string GUUID { get; set; }

        public string  Phone{set;get;  }
        public void Save_info()
        {
            js.Write_jsonfile(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
        public Userinfo Load_info()
        {
            var res=Newtonsoft.Json.JsonConvert.DeserializeObject<Userinfo>( js.Read_jsonfile());
            return res;
        }
    }
    public class UserCollection:List<Userinfo>
    {
        public UserCollection()
        {

        }
        static jsonhelper.Json_helper json=new jsonhelper.Json_helper(@"./users.json");
        public void Save_info()
        {
             json.Write_jsonfile(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
        public UserCollection Load_info()
        {
            var res=Newtonsoft.Json.JsonConvert.DeserializeObject<UserCollection>( json.Read_jsonfile());
            return res;
        }
        //public List MyProperty { get; set; }
    }
}
