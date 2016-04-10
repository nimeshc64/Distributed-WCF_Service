using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DisasterServices
{
    [ServiceContract]
    public interface IDisasterService
    {

    }

    #region Area
    [ServiceContract]
    public interface IAreaService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "save", ResponseFormat = WebMessageFormat.Json, 
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool InsertArea(Area area);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateArea(Area area);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteArea(Area area);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findArea", ResponseFormat = WebMessageFormat.Json)]
        List<Area> GetAllArea();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findArea/{id}", ResponseFormat = WebMessageFormat.Json)]
        Area GetAreaByID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "maxAreaid", ResponseFormat = WebMessageFormat.Json)]
        Area GetMaxAreaID();
    }
    #endregion

    #region Disaster type
    [ServiceContract]
    public interface IDisasterTypeService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "save", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool InsertDisasterType(Disaster_Type type);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateDisasterType(Disaster_Type type);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteDisasterType(Disaster_Type type);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findDisType", ResponseFormat = WebMessageFormat.Json)]
        List<Disaster_Type> GetAllDisasterType();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findDisType/{id}", ResponseFormat = WebMessageFormat.Json)]
        Disaster_Type GetDisasterTypeByID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "maxDisTypeid", ResponseFormat = WebMessageFormat.Json)]
        Disaster_Type GetMaxDisasterTypeID();
    }
    #endregion

    #region Suggestion
    [ServiceContract]
    public interface ISuggestion
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "save", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool InsertSuggestion(Suggestion suggestion);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateSuggestion(Suggestion suggestion);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteSuggestion(Suggestion suggestion);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findSuggestion", ResponseFormat = WebMessageFormat.Json)]
        List<Suggestion> GetAllSuggestion();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findSuggestion/{id}", ResponseFormat = WebMessageFormat.Json)]
        Suggestion GetSuggestionByID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "maxSuggestionid", ResponseFormat = WebMessageFormat.Json)]
        Suggestion GetMaxSuggestionID();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAreabySuggestion", ResponseFormat = WebMessageFormat.Json)]
        List<Area> GetAreabySuggestion();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getUserbySuggestion", ResponseFormat = WebMessageFormat.Json)]
        List<User> GetUserbySuggestion();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getDisasterbySuggestion", ResponseFormat = WebMessageFormat.Json)]
        List<Disaster_Type> GetDisasterbySuggestion();
    }
    #endregion

    #region User
    [ServiceContract]
    public interface Iuser
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "save", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool InsertUser(User user);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateUser(User user);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteUser(User user);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser", ResponseFormat = WebMessageFormat.Json)]
        List<User> GetAllUser();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUser/{id}", ResponseFormat = WebMessageFormat.Json)]
        User GetUserByID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "maxUserid", ResponseFormat = WebMessageFormat.Json)]
        User GetMaxUserID();
    }
    #endregion

    #region User alerts
    [ServiceContract]
    public interface IUserAlerts
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "save", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool InsertUserAlerts(UserAlert useralerts);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool UpdateUserAlerts(UserAlert useralerts);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool DeleteUserAlerts(UserAlert useralerts);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUserAlerts", ResponseFormat = WebMessageFormat.Json)]
        List<UserAlert> GetAllUserAlerts();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findUserAlerts/{id}", ResponseFormat = WebMessageFormat.Json)]
        UserAlert GetUserAlertsByID(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "maxUserAlertsid", ResponseFormat = WebMessageFormat.Json)]
        UserAlert GetMaxUserAlertsID();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getAreabyAlerts", ResponseFormat = WebMessageFormat.Json)]
        List<Area> GetAreabyUserA();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "getDisasterbyAlerts", ResponseFormat = WebMessageFormat.Json)]
        List<Disaster_Type> GetDisasterbyUserA();
    }
    #endregion
}
