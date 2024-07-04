#nullable enable
using System;
using System.Collections.Generic;
using System.Xml;

namespace ClassicByte.Cucumber.Core
{
    /// <summary>
    /// 实例化一个用户对象
    /// </summary>
    /// <param name="uid"></param>
    /// <param name="password"></param>
    public class User(String uid, String password)
    {
        /// <summary>
        /// 用户的唯一标识符
        /// </summary>
        public String UID { get; set; } = uid;

        /// <summary>
        /// 用户的密码
        /// </summary>
        public String Password { get; set; } = password;

        /// <summary>
        /// 获取当前在线的用户
        /// </summary>
        /// <returns></returns>
        public static User? GetCurrentUser()
        {
            //TODO 定义当前在线用户
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public static User? Login(String uid, String password)
        {
            var user = User.GetUserById(uid);
            if(user != null && user.Password == password)
            {
                return user;
            }
            return null;
        }

        /// <summary>
        /// 从用户配置表中获取用户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static User? GetUserById(String uid)
        {
            return AllUsers.Find(x => x.UID == uid);
        }

        private static Config UserTable => Config.UserConfig;

        /// <summary>
        /// 获取所有用户的<see cref="List{User}"/>对象
        /// </summary>
        public static List<User> AllUsers
        {
            get
            {
                var userNodes = UserTable.XmlDocument.DocumentElement.SelectNodes("UserItem");
                List<User> users = new(userNodes.Count);
                foreach (XmlNode item in userNodes)
                {
                    users.Add(new User(item.Attributes["UID"].Value, item.Attributes["Password"].Value));
                }
                return users;
            }
        }
    }
}
