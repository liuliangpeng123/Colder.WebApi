using LiuLiangPeng.Entity.Base_Manage;
using LiuLiangPeng.Util;
using System.Collections.Generic;

namespace LiuLiangPeng.Business.Base_Manage
{
    public interface IBuildCodeBusiness
    {
        List<Base_DbLink> GetAllDbLink();

        List<DbTableInfo> GetDbTableList(string linkId);

        void Build(BuildInputDTO input);
    }

    public class DbTablesInputDTO
    {
        public string linkId { get; set; }
    }

    public class BuildInputDTO
    {
        public string linkId { get; set; }
        public string areaName { get; set; }
        public List<string> tables { get; set; }
        public List<int> buildTypes { get; set; }
    }
}
