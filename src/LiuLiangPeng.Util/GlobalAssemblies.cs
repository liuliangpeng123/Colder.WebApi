using System;
using System.Linq;
using System.Reflection;

namespace LiuLiangPeng.Util
{
    public static class GlobalAssemblies
    {
        /// <summary>
        /// 解决方案所有程序集
        /// </summary>
        public static readonly Assembly[] AllAssemblies = new Assembly[]
        {
            Assembly.Load("LiuLiangPeng.Util"),
            Assembly.Load("LiuLiangPeng.Entity"),
            Assembly.Load("LiuLiangPeng.IBusiness"),
            Assembly.Load("LiuLiangPeng.Business"),
            Assembly.Load("LiuLiangPeng.Api"),
        };

        /// <summary>
        /// 解决方案所有自定义类
        /// </summary>
        public static readonly Type[] AllTypes = AllAssemblies.SelectMany(x => x.GetTypes()).ToArray();

        /// <summary>
        /// 超级管理员UserIId
        /// </summary>
        public const string ADMINID = "Admin";
    }
}
