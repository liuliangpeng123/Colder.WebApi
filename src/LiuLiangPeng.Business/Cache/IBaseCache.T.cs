﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiuLiangPeng.Business.Cache
{
    public interface IBaseCache<T> where T : class
    {
        Task<T> GetCacheAsync(string idKey);
        Task UpdateCacheAsync(string idKey);
        Task UpdateCacheAsync(List<string> idKeys);
    }
}