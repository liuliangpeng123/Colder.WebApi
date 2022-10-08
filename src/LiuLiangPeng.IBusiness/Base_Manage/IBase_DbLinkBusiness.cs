using LiuLiangPeng.Entity.Base_Manage;
using LiuLiangPeng.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiuLiangPeng.Business.Base_Manage
{
    public interface IBase_DbLinkBusiness
    {
        Task<PageResult<Base_DbLink>> GetDataListAsync(PageInput input);
        Task<Base_DbLink> GetTheDataAsync(string id);
        Task AddDataAsync(Base_DbLink newData);
        Task UpdateDataAsync(Base_DbLink theData);
        Task DeleteDataAsync(List<string> ids);
    }
}