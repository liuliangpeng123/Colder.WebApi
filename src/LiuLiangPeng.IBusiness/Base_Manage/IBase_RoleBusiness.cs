﻿using LiuLiangPeng.Entity;
using LiuLiangPeng.Entity.Base_Manage;
using LiuLiangPeng.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiuLiangPeng.Business.Base_Manage
{
    public interface IBase_RoleBusiness
    {
        Task<PageResult<Base_RoleInfoDTO>> GetDataListAsync(PageInput<RolesInputDTO> input);
        Task<Base_RoleInfoDTO> GetTheDataAsync(string id);
        Task AddDataAsync(Base_RoleInfoDTO input);
        Task UpdateDataAsync(Base_RoleInfoDTO input);
        Task DeleteDataAsync(List<string> ids);
    }

    public class RolesInputDTO
    {
        public string roleId { get; set; }
        public string roleName { get; set; }
    }

    [Map(typeof(Base_Role))]
    public class Base_RoleInfoDTO : Base_Role
    {
        public RoleTypes? RoleType { get => RoleName?.ToEnum<RoleTypes>(); }
        public List<string> Actions { get; set; } = new List<string>();
    }
}