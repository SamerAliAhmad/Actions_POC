using System;
using System.Linq;
using SmartrTools;
using System.Xml.Linq;
using System.Collections.Generic;

namespace BLC
{
    #region BLC
    public partial class BLC : IDisposable
    {
        #region Constructor
        public BLC(string i_Ticket)
        {
            Init(Prepare_BLC_Initializer(i_Ticket));
        }
        public BLC(BLC_Initializer i_BLC_Initializer)
        {
            Init(i_BLC_Initializer);
        }
        #endregion
        #region Init
        public void Init(BLC_Initializer i_BLC_Initializer)
        {
            #region Body Section.
            // ---------------------
            this.oBLC_Initializer = i_BLC_Initializer;
            // ---------------------
            Load_Messages();
            #endregion
        }
        #endregion
        #region Subscribe To Events
        public void Subscribe_To_Events()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region IDisposable Members
        public void Dispose()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region Load_Messages
        public void Load_Messages()
        {
            #region Declaration And Initialization Section.
            XElement oRoot = null;
            XElement oLanguage = null;
            #endregion
            #region Body Section.
            this.oList_Message = new List<Message>();

            if (this.oBLC_Initializer.Messages_File_Path != null)
            {
                oRoot = XElement.Load(this.oBLC_Initializer.Messages_File_Path);
                if (oRoot != null)
                {
                    switch (this.oBLC_Initializer.Language)
                    {
                        case Enum_Language.English:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                        case Enum_Language.Arabic:
                            oLanguage = oRoot.Element("ARABIC");
                            break;
                        default:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                    }
                    if (oLanguage != null)
                    {
                        foreach (var oMessage in oLanguage.Elements("MESSAGE").Where(oMessage => oMessage.Attribute("CODE") != null && oMessage.Attribute("CONTENT") != null))
                        {
                            this.oList_Message.Add(new Message()
                            {
                                Code = oMessage.Attribute("CODE").Value,
                                Content = oMessage.Attribute("CONTENT").Value
                            });
                        }
                    }
                }
            }
            #endregion
        }
        #endregion
        #region Get_Message_Content
        public string Get_Message_Content(Enum_BR_Codes i_BR_Code)
        {
            if (this.oList_Message == null || this.oList_Message == default || this.oList_Message.Count == 0)
            {
                Load_Messages();
            }
            if (this.oList_Message != null && this.oList_Message != default && this.oList_Message.Count > 0)
            {
                var oMessage = this.oList_Message.FirstOrDefault(oMessage => oMessage.Code == i_BR_Code.ToString());
                if (oMessage != null && oMessage != default && oMessage.Content != default)
                {
                    return oMessage.Content;
                }
                else
                {
                    return "Cannot Load Desired Message";
                }
            }
            else
            {
                return "Cannot Load Desired Message";
            }
        }
        public string Get_Message_Content(Enum_BR_Codes i_BR_Code, Dictionary<string, string> i_PlaceHolders)
        {
            string oReturnValue = string.Empty;
            if (this.oList_Message == null || this.oList_Message == default || this.oList_Message.Count == 0)
            {
                Load_Messages();
            }
            if (this.oList_Message != null && this.oList_Message != default && this.oList_Message.Count > 0)
            {
                var oMessage = this.oList_Message.FirstOrDefault(oMessage => oMessage.Code == i_BR_Code.ToString());
                if (oMessage != null && oMessage != default && oMessage.Content != default)
                {
                    oReturnValue = oMessage.Content;
                    foreach (var oPlaceHolder in i_PlaceHolders)
                    {
                        oReturnValue = oReturnValue.Replace(oPlaceHolder.Key, oPlaceHolder.Value);
                    }
                    return oReturnValue;
                }
                else
                {
                    return "Cannot Load Desired Message";
                }
            }
            else
            {
                return "Cannot Load Desired Message";
            }
        }
        #endregion
        #region Events Implementation
        #endregion
    }
    #endregion
}
