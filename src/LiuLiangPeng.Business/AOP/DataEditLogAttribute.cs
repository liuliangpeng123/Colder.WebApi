﻿using LiuLiangPeng.IBusiness;
using LiuLiangPeng.Util;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace LiuLiangPeng.Business
{
    public class DataEditLogAttribute : WriteDataLogAttribute
    {
        public DataEditLogAttribute(UserLogType logType, string nameField, string dataName)
            : base(logType, nameField, dataName)
        {
        }

        public override async Task After(IAOPContext context)
        {
            var op = context.ServiceProvider.GetService<IOperator>();
            var obj = context.Arguments[0];
            op.WriteUserLog(_logType, $"修改{_dataName}:{obj.GetPropertyValue(_nameField)?.ToString()}");

            await Task.CompletedTask;
        }
    }
}
