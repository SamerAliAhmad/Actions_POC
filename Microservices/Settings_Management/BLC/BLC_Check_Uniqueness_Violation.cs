using System;
using System.Linq;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Check_Setup_category_Uniqueness_Violation
        public bool Check_Setup_category_Uniqueness_Violation(Setup_category i_Setup_category)
        {
            Setup_category oSetup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
            {
                SETUP_CATEGORY_NAME = i_Setup_category.SETUP_CATEGORY_NAME,
                OWNER_ID = i_Setup_category.OWNER_ID
            });
            if (oSetup_category != null && oSetup_category.SETUP_CATEGORY_ID != i_Setup_category.SETUP_CATEGORY_ID)
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Check_Setup_Uniqueness_Violation
        public bool Check_Setup_Uniqueness_Violation(Setup i_Setup)
        {
            Setup oSetup = Get_Setup_By_SETUP_CATEGORY_ID_VALUE(new Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE()
            {
                SETUP_CATEGORY_ID = i_Setup.SETUP_CATEGORY_ID,
                VALUE = i_Setup.VALUE
            });
            if (oSetup != null && oSetup.SETUP_ID != i_Setup.SETUP_ID)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}