using LiuLiangPeng.Entity.Base_Manage;
using LiuLiangPeng.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiuLiangPeng.Business.Base_Manage
{
    public interface IBase_AppSecretBusiness
    {
        Task<PageResult<Base_AppSecret>> GetDataListAsync(PageInput<AppSecretsInputDTO> input);
        Task<Base_AppSecret> GetTheDataAsync(string id);
        Task<string> GetAppSecretAsync(string appId);
        Task AddDataAsync(Base_AppSecret newData);
        Task UpdateDataAsync(Base_AppSecret theData);
        Task DeleteDataAsync(List<string> ids);
    }

    public class AppSecretsInputDTO
    {
        public string keyword { get; set; }
    }
}