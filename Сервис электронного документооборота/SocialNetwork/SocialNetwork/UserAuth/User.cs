﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.UserAuth
{
    class User:IuserCheck 
    {

        void IuserCheck.checkData(string username, string pass, string name, string email)
        {
            throw new NotImplementedException();
        }

        void IuserCheck.RetrievePass(string email)
        {
            throw new NotImplementedException();
        }

 
    }
}
