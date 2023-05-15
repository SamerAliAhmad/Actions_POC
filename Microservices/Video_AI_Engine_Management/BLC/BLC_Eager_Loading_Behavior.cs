using System.Linq;
using SmartrTools;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading(Setup_category i_Result, Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null)
            {
                // ---------------------
                // Get All available Setup entries.
                // ---------------------
                i_Result.List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID()
                {
                    SETUP_CATEGORY_ID = i_Result.SETUP_CATEGORY_ID
                });
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading(List<Setup_category> i_Result, Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Setup_category_ID_List = i_Result.Select(setup_category => setup_category.SETUP_CATEGORY_ID).OrderBy(Setup_category_ID => Setup_category_ID);

                // ---------------------
                // Get All available Setup entries.
                // ---------------------
                List<Setup> oList_Setup = Get_Setup_By_SETUP_CATEGORY_ID_List(new Params_Get_Setup_By_SETUP_CATEGORY_ID_List()
                {
                    SETUP_CATEGORY_ID_LIST = Setup_category_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSetup_category =>
                {
                    oSetup_category.List_Setup = oList_Setup.Where(oSetup => oSetup.SETUP_CATEGORY_ID == oSetup_category.SETUP_CATEGORY_ID).ToList();
                    return oSetup_category;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Video_ai_engine_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Video_ai_engine_By_OWNER_ID_Eager_Loading(List<Video_ai_engine> i_Result, Params_Get_Video_ai_engine_By_OWNER_ID i_Params_Get_Video_ai_engine_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Video_ai_engine_ID_List = i_Result.Select(video_ai_engine => video_ai_engine.VIDEO_AI_ENGINE_ID).OrderBy(Video_ai_engine_ID => Video_ai_engine_ID);

                // ---------------------
                // Get All available Video_ai_instance entries.
                // ---------------------
                List<Video_ai_instance> oList_Video_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv(new Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List()
                {
                    VIDEO_AI_ENGINE_ID_LIST = Video_ai_engine_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oVideo_ai_engine =>
                {
                    oVideo_ai_engine.List_Video_ai_instance = oList_Video_ai_instance.Where(oVideo_ai_instance => oVideo_ai_instance.VIDEO_AI_ENGINE_ID == oVideo_ai_engine.VIDEO_AI_ENGINE_ID).ToList();
                    return oVideo_ai_engine;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region Initialize_Eager_Loading_Mechanism
        public void Initialize_Eager_Loading_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Video_ai_engine_By_OWNER_ID += new PostEvent_Handler_Get_Video_ai_engine_By_OWNER_ID(BLC_OnPostEvent_Get_Video_ai_engine_By_OWNER_ID_Eager_Loading);
            #endregion
        }
        #endregion
    }
}