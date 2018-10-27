using System;
using System.Collections.Generic;
using System.Text;

namespace IceDog.xUnit.Test.Mocks
{
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public virtual Guid Id { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 产品分类
        /// </summary>
        public virtual string Category { get; set; }
        /// <summary>
        /// 是否停产
        /// </summary>
        public virtual bool Discontinued { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public virtual DateTime ProductionDate { get; set; }
    }
}
