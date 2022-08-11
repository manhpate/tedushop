using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        string MetaKeyword { set; get; }

        [MaxLength(256)]
        string MetaDescription { set; get; }

        public bool Status { get; set; }
        string IAuditable.MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAuditable.MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}