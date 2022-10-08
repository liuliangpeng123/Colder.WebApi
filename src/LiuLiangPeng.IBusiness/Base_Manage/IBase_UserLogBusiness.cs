using LiuLiangPeng.Entity.Base_Manage;
using LiuLiangPeng.Util;
using System;
using System.Threading.Tasks;

namespace LiuLiangPeng.Business.Base_Manage
{
    public interface IBase_UserLogBusiness
    {
        Task<PageResult<Base_UserLog>> GetLogListAsync(PageInput<UserLogsInputDTO> input);
    }

    public class UserLogsInputDTO
    {
        public string logContent { get; set; }
        public string logType { get; set; }
        public string opUserName { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime? endTime { get; set; }
    }
}