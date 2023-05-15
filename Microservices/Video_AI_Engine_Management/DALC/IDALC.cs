using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID
        Video_ai_search_category Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID(int? VIDEO_AI_SEARCH_CATEGORY_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID
        Video_ai_asset_entity Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID(int? VIDEO_AI_ASSET_ENTITY_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID
        Video_ai_engine Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
        Video_ai_instance Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(int? VIDEO_AI_INSTANCE_ID);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
        Video_ai_asset Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(int? VIDEO_AI_ASSET_ID);
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List
        List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List(IEnumerable<int?> VIDEO_AI_SEARCH_CATEGORY_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List(IEnumerable<int?> VIDEO_AI_ASSET_ENTITY_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List
        List<Video_ai_engine> Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List
        List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST);
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID
        List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
        List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED
        List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(int? VIDEO_AI_ASSET_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID
        List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_engine_By_OWNER_ID
        List<Video_ai_engine> Get_Video_ai_engine_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_engine_By_OWNER_ID_IS_DELETED
        List<Video_ai_engine> Get_Video_ai_engine_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID
        List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
        List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
        List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(long? CONNECTION_TYPE_SETUP_ID);
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_IS_DELETED
        List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID
        List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(int? VIDEO_AI_INSTANCE_ID);
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID
        List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID);
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_IS_DELETED
        List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(int? VIDEO_AI_ASSET_ID_REF);
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List
        List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_List
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List
        List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST);
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List
        List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List(IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List
        List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_List(IEnumerable<long?> SPACE_ASSET_ID_LIST);
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
        List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(IEnumerable<int?> VIDEO_AI_ASSET_ID_REF_LIST);
        #endregion
        #region Get_Video_ai_search_category_By_Where
        List<Video_ai_search_category> Get_Video_ai_search_category_By_Where(string CATEGORY_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_entity_By_Where
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_engine_By_Where
        List<Video_ai_engine> Get_Video_ai_engine_By_Where(string ENGINE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_instance_By_Where
        List<Video_ai_instance> Get_Video_ai_instance_By_Where(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_By_Where
        List<Video_ai_asset> Get_Video_ai_asset_By_Where(string FRIENDLY_NAME, string FUNCTIONAL_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_search_category_By_Where_In_List
        List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_In_List(string CATEGORY_NAME, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_In_List
        List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_instance_By_Where_In_List
        List<Video_ai_instance> Get_Video_ai_instance_By_Where_In_List(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Video_ai_asset_By_Where_In_List
        List<Video_ai_asset> Get_Video_ai_asset_By_Where_In_List(string FRIENDLY_NAME, string FUNCTIONAL_NAME, IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST, IEnumerable<long?> SPACE_ASSET_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Video_ai_search_category
        void Delete_Video_ai_search_category(int? VIDEO_AI_SEARCH_CATEGORY_ID);
        #endregion
        #region Delete_Video_ai_asset_entity
        void Delete_Video_ai_asset_entity(int? VIDEO_AI_ASSET_ENTITY_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Video_ai_engine
        void Delete_Video_ai_engine(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Delete_Video_ai_instance
        void Delete_Video_ai_instance(int? VIDEO_AI_INSTANCE_ID);
        #endregion
        #region Delete_Video_ai_asset
        void Delete_Video_ai_asset(int? VIDEO_AI_ASSET_ID);
        #endregion
        #region Delete_Video_ai_search_category_By_OWNER_ID
        void Delete_Video_ai_search_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
        void Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED
        void Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Video_ai_asset_entity_By_OWNER_ID
        void Delete_Video_ai_asset_entity_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
        void Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(int? VIDEO_AI_ASSET_ID);
        #endregion
        #region Delete_Video_ai_asset_entity_By_ENTITY_ID
        void Delete_Video_ai_asset_entity_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
        void Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Delete_Setup_By_OWNER_ID
        void Delete_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Video_ai_engine_By_OWNER_ID
        void Delete_Video_ai_engine_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED
        void Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Video_ai_instance_By_OWNER_ID
        void Delete_Video_ai_instance_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
        void Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID);
        #endregion
        #region Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
        void Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(long? CONNECTION_TYPE_SETUP_ID);
        #endregion
        #region Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED
        void Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Video_ai_asset_By_OWNER_ID
        void Delete_Video_ai_asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
        void Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(int? VIDEO_AI_INSTANCE_ID);
        #endregion
        #region Delete_Video_ai_asset_By_SPACE_ASSET_ID
        void Delete_Video_ai_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID);
        #endregion
        #region Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED
        void Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
        void Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(int? VIDEO_AI_ASSET_ID_REF);
        #endregion
        #region Edit_Video_ai_search_category
        int? Edit_Video_ai_search_category(int? VIDEO_AI_SEARCH_CATEGORY_ID, int? VIDEO_AI_ENGINE_ID, string CATEGORY_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Video_ai_asset_entity
        int? Edit_Video_ai_asset_entity(int? VIDEO_AI_ASSET_ENTITY_ID, int? VIDEO_AI_ASSET_ID, long? ENTITY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Video_ai_engine
        int? Edit_Video_ai_engine(int? VIDEO_AI_ENGINE_ID, string ENGINE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Video_ai_instance
        int? Edit_Video_ai_instance(int? VIDEO_AI_INSTANCE_ID, int? VIDEO_AI_ENGINE_ID, string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, long? CONNECTION_TYPE_SETUP_ID, string USERNAME, string PASSWORD, bool IS_LPR, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Video_ai_asset
        int? Edit_Video_ai_asset(int? VIDEO_AI_ASSET_ID, int? VIDEO_AI_INSTANCE_ID, long? SPACE_ASSET_ID, string FRIENDLY_NAME, int? VIDEO_AI_ASSET_ID_REF, string FUNCTIONAL_NAME, int? RESOLUTION_X, int? RESOLUTION_Y, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
