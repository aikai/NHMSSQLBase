using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectBase.Utils.Commons;
using ProjectBase.Utils.Components;

namespace ProjectBase.Core.Model
{
    public interface IHrPosition
    {
        Guid Id { get; set; }

        string ThaiName { get; set; }
        string EnglishName { get; set; }

        #region TransactionLog
        IUserAccount CreateBy { get; set; }
        IValueValidation CreateDate { get; set; }
        IUserAccount UpdateBy { get; set; }
        IValueValidation UpdateDate { get; set; } 
        #endregion

        bool Equals(object obj);
        bool Equals(IHrPosition obj);
        int GetHashCode();
    }
}
