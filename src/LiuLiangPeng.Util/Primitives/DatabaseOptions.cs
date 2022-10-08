using EFCore.Sharding;

namespace LiuLiangPeng.Util
{
    public class DatabaseOptions
    {
        public string ConnectionString { get; set; }
        public DatabaseType  DatabaseType { get; set; }
    }
}
