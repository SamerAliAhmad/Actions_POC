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
        #region Check_User_Uniqueness_Violation
        public bool Check_User_Uniqueness_Violation(User i_User)
        {
            User oUser = Get_User_By_USERNAME_OWNER_ID(new Params_Get_User_By_USERNAME_OWNER_ID()
            {
                USERNAME = i_User.USERNAME,
                OWNER_ID = i_User.OWNER_ID
            });
            if (oUser != null && oUser.USER_ID != i_User.USER_ID)
            {
                return true;
            }
            User oUser_Ind_1 = Get_User_By_EMAIL_OWNER_ID(new Params_Get_User_By_EMAIL_OWNER_ID()
            {
                EMAIL = i_User.EMAIL,
                OWNER_ID = i_User.OWNER_ID
            });
            if (oUser_Ind_1 != null && oUser_Ind_1.USER_ID != i_User.USER_ID)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}