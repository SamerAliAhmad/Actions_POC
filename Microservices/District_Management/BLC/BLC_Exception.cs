using System;

namespace BLC
{
    public partial class BLC_Exception : Exception
    {
        #region Constructors
        public BLC_Exception(string i_MessageContent) : base(i_MessageContent) { }
        #endregion
    }
}