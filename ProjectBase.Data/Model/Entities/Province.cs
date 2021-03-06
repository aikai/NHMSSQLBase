using System;
using System.Collections.Generic;
using ProjectBase.Core.Model;
using ProjectBase.Utils.Commons;

namespace ProjectBase.Data.Model
{
	[Serializable]
    public partial class Province : EntityBase,  IProvince
	{
		public Province()
		{
            Amphoes = new Iesi.Collections.Generic.HashedSet<IAmphoe>();
		}

        public virtual string ShortName { get; set; }

        public virtual Iesi.Collections.Generic.ISet<IAmphoe> Amphoes
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            return Equals(obj as IProvince);
        }

        public virtual bool Equals(IProvince obj)
        {
            if (obj == null) return false;

            if (Equals(CreateBy, obj.CreateBy) == false) return false;
            if (Equals(CreateDate, obj.CreateDate) == false) return false;
            if (Equals(EnglishName, obj.EnglishName) == false) return false;
            if (Equals(Id, obj.Id) == false) return false;
            if (Equals(ThaiName, obj.ThaiName) == false) return false;
            if (Equals(ShortName, obj.ShortName) == false) return false;
            if (Equals(UpdateBy, obj.UpdateBy) == false) return false;
            if (Equals(UpdateDate, obj.UpdateDate) == false) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int result = 1;

            result = (result * 397) ^ (CreateBy != null ? CreateBy.GetHashCode() : 0);
            result = (result * 397) ^ (CreateDate != null ? CreateDate.GetHashCode() : 0);
            result = (result * 397) ^ (EnglishName != null ? EnglishName.GetHashCode() : 0);
            result = (result * 397) ^ Id.GetHashCode();
            result = (result * 397) ^ (ThaiName != null ? ThaiName.GetHashCode() : 0);
            result = (result * 397) ^ (ShortName != null ? ShortName.GetHashCode() : 0);
            result = (result * 397) ^ (UpdateBy != null ? UpdateBy.GetHashCode() : 0);
            result = (result * 397) ^ (UpdateDate != null ? UpdateDate.GetHashCode() : 0);
            return result;
        }
	}
}