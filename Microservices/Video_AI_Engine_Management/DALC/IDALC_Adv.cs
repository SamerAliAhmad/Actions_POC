using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv
        Video_ai_search_category Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv(int? VIDEO_AI_SEARCH_CATEGORY_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv
        Video_ai_asset_entity Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv(int? VIDEO_AI_ASSET_ENTITY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv
        Video_ai_instance Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv(int? VIDEO_AI_INSTANCE_ID);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv
        Video_ai_asset Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(int? VIDEO_AI_ASSET_ID);
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv(IEnumerable<int?> VIDEO_AI_SEARCH_CATEGORY_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ENTITY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST);
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv(int? VIDEO_AI_ASSET_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(long? ENTITY_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv(long? CONNECTION_TYPE_SETUP_ID);
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv(int? VIDEO_AI_INSTANCE_ID);
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv(long? SPACE_ASSET_ID);
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv(int? VIDEO_AI_ASSET_ID_REF);
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST);
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(IEnumerable<long?> SPACE_ASSET_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ID_REF_LIST);
        #endregion
        #region Get_Video_ai_search_category_By_Where_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_Adv(string CATEGORY_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_instance_By_Where_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_Where_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_By_Where_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_Where_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_search_category_By_Where_In_List_Adv
        List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_In_List_Adv(string CATEGORY_NAME, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_In_List_Adv
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_instance_By_Where_In_List_Adv
        List<Video_ai_instance> Get_Video_ai_instance_By_Where_In_List_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_By_Where_In_List_Adv
        List<Video_ai_asset> Get_Video_ai_asset_By_Where_In_List_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST, IEnumerable<long?> SPACE_ASSET_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
