﻿
namespace Shared
{
    public partial class ProductShared
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Value { get; set; }
        public int BcrId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUserId { get; set; }
        public int UpdateUserId { get; set; }
        public int StatusId { get; set; }

    }
}
