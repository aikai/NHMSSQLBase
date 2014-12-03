using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectBase.Utils.Commons;
using ProjectBase.Utils.Components;

namespace ProjectBase.Core.Model
{
    public interface IProvince
    {
        Guid Id { get; set; }

        string ThaiName { get; set; }
        string EnglishName { get; set; }

        string ShortName { get; set; }

        #region TransactionLog
        IUserAccount CreateBy { get; set; }
        IValueValidation CreateDate { get; set; }
        IUserAccount UpdateBy { get; set; }
        IValueValidation UpdateDate { get; set; }
        #endregion

        Iesi.Collections.Generic.ISet<IAmphoe> Amphoes { get; set; }

        bool Equals(object obj);
        bool Equals(IProvince obj);
        int GetHashCode();
    }
}
