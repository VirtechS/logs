﻿using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user,pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

        public bool editPassword(int user, string pass)
        {
           if (user == UserLoginCache.id)
            {

            }
            return true;
        }
        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrator)
            {

            }
            if (UserLoginCache.Position == Positions.Client)
            {

            }
            if (UserLoginCache.Position == Positions.Courier)
            {

            }
        }
    }
}