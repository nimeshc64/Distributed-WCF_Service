using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DisasterServices
{
    
    public class DisasterService : IDisasterService, IAreaService,IDisasterTypeService,ISuggestion,Iuser,IUserAlerts
    {
        #region area
        public bool InsertArea(Area area)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Areas
                                 select info);

                    entitie.Areas.Add(area);
                    entitie.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateArea(Area area)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                        var query = (from Info in entitie.Areas
                                     select Info);

                        if (query.Any())
                        {
                            entitie.Areas.Remove(query.First());
                            entitie.SaveChanges();

                            entitie.Areas.Add(area);
                            entitie.SaveChanges();
                        }
                  }
                return true;
                }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteArea(Area area)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from details in entitie.Areas
                                 where details.A_id == area.A_id &&
                                 details.Area_name == area.Area_name
                                 select details);

                    if (query.Any())
                    {
                        entitie.Areas.Remove(query.First());
                        entitie.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Area> GetAllArea()
        {
            try
            {
                List<Area> area = new List<Area>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Areas
                                 select info);

                    if (query.Any())
                        area = query.ToList();
                };
                return area;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Area GetAreaByID(string id)
        {
            try
            {
                Area area = new Area();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Areas
                                 where info.A_id==id
                                 select info);

                    if (query.Any())
                        area = query.First();
                };
                return area;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Area GetMaxAreaID()
        {
            try
            {
                Area area = new Area();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Areas
                                 orderby info.A_id descending
                                 select info).Take(1);

                    if (query.Any())
                        area = query.First();
                };
                return area;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region disaster type
        public bool InsertDisasterType(Disaster_Type type)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Disaster_Type
                                 select info);

                    entitie.Disaster_Type.Add(type);
                    entitie.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateDisasterType(Disaster_Type type)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from Info in entitie.Disaster_Type
                                 select Info);

                    if (query.Any())
                    {
                        entitie.Disaster_Type.Remove(query.First());
                        entitie.SaveChanges();

                        entitie.Disaster_Type.Add(type);
                        entitie.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteDisasterType(Disaster_Type type)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from details in entitie.Disaster_Type
                                 where details.D_id == type.D_id &&
                                 details.Disaster_Name == type.Disaster_Name
                                 select details);

                    if (query.Any())
                    {
                        entitie.Disaster_Type.Remove(query.First());
                        entitie.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Disaster_Type> GetAllDisasterType()
        {
            try
            {
                List<Disaster_Type> disasterType = new List<Disaster_Type>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Disaster_Type
                                 select info);

                    if (query.Any())
                        disasterType = query.ToList();
                };
                return disasterType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Disaster_Type GetDisasterTypeByID(string id)
        {
            try
            {
                Disaster_Type disasterType = new Disaster_Type();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Disaster_Type
                                 where info.D_id == id
                                 select info);

                    if (query.Any())
                        disasterType = query.First();
                };
                return disasterType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Disaster_Type GetMaxDisasterTypeID()
        {
            try
            {
                Disaster_Type type = new Disaster_Type();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Disaster_Type
                                 orderby info.D_id descending
                                 select info).Take(1);

                    if (query.Any())
                        type = query.First();
                };
                return type;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region suggestion
        public bool InsertSuggestion(Suggestion suggestion)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Suggestions
                                 select info);

                    entitie.Suggestions.Add(suggestion);
                    entitie.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateSuggestion(Suggestion suggestion)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from Info in entitie.Suggestions
                                 select Info);

                    if (query.Any())
                    {
                        entitie.Suggestions.Remove(query.First());
                        entitie.SaveChanges();

                        entitie.Suggestions.Add(suggestion);
                        entitie.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteSuggestion(Suggestion suggestion)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from details in entitie.Suggestions
                                 where details.S_id == suggestion.S_id 
                                 select details);

                    if (query.Any())
                    {
                        entitie.Suggestions.Remove(query.First());
                        entitie.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Suggestion> GetAllSuggestion()
        {
            try
            {
                List<Suggestion> suggestion = new List<Suggestion>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Suggestions
                                 select info);

                    if (query.Any())
                        suggestion = query.ToList();
                };
                return suggestion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Suggestion GetSuggestionByID(string id)
        {
            try
            {
                Suggestion suggestion = new Suggestion();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Suggestions
                                 where info.S_id==id
                                 select info);

                    if (query.Any())
                        suggestion = query.First();
                };
                return suggestion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Suggestion GetMaxSuggestionID()
        {
            try
            {
                Suggestion suggestion = new Suggestion();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Suggestions
                                 orderby info.S_id descending
                                 select info).Take(1);

                    if (query.Any())
                        suggestion = query.First();
                };
                return suggestion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Area> GetAreabySuggestion()
        {
            try
            {
                List<Suggestion> suggestion = new List<Suggestion>();
                List<Area> areaList = new List<Area>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query1 = (from sugg in entitie.Suggestions select sugg);
                    if (query1.Any())
                        suggestion = query1.ToList();

                    foreach (Suggestion sug in suggestion)
                    {
                        var query = (from info in entitie.Areas
                                     where info.A_id == sug.Area_id
                                     select info);
                        areaList.Add(query.First());

                    }

                };
                return areaList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<User> GetUserbySuggestion()
        {
            try
            {
                List<Suggestion> suggestion = new List<Suggestion>();
                List<User> userList = new List<User>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query1 = (from sugg in entitie.Suggestions select sugg);
                    if (query1.Any())
                        suggestion = query1.ToList();

                    foreach (Suggestion sug in suggestion)
                    {
                        var query = (from info in entitie.Users
                                     where info.U_id == sug.User_id
                                     select info);
                        userList.Add(query.First());

                    }

                };
                return userList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Disaster_Type> GetDisasterbySuggestion()
        {
            try
            {
                List<Suggestion> suggestion = new List<Suggestion>();
                List<Disaster_Type> disasterList = new List<Disaster_Type>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query1 = (from sugg in entitie.Suggestions select sugg);
                    if (query1.Any())
                        suggestion = query1.ToList();

                    foreach (Suggestion sug in suggestion)
                    {
                        var query = (from info in entitie.Disaster_Type
                                     where info.D_id == sug.Disaster_id
                                     select info);
                        disasterList.Add(query.First());

                    }

                };
                return disasterList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region user
        public bool InsertUser(User user)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Users
                                 select info);

                    entitie.Users.Add(user);
                    entitie.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from Info in entitie.Users
                                 select Info);

                    if (query.Any())
                    {
                        entitie.Users.Remove(query.First());
                        entitie.SaveChanges();

                        entitie.Users.Add(user);
                        entitie.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteUser(User user)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from details in entitie.Users
                                 where details.U_id == user.U_id 
                                 select details);

                    if (query.Any())
                    {
                        entitie.Users.Remove(query.First());
                        entitie.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<User> GetAllUser()
        {
            try
            {
                List<User> user = new List<User>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Users
                                 select info);

                    if (query.Any())
                        user = query.ToList();
                };
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User GetUserByID(string id)
        {
            try
            {
                User user = new User();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Users
                                 where info.U_id==id
                                 select info);

                    if (query.Any())
                        user = query.First();
                };
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User GetMaxUserID()
        {
            try
            {
                User user = new User();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.Users
                                 orderby info.U_id descending
                                 select info).Take(1);

                    if (query.Any())
                        user = query.First();
                };
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region user alert
        public bool InsertUserAlerts(UserAlert useralerts)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.UserAlerts
                                 select info);

                    entitie.UserAlerts.Add(useralerts);
                    entitie.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateUserAlerts(UserAlert useralerts)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from Info in entitie.UserAlerts
                                 select Info);

                    if (query.Any())
                    {
                        entitie.UserAlerts.Remove(query.First());
                        entitie.SaveChanges();

                        entitie.UserAlerts.Add(useralerts);
                        entitie.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteUserAlerts(UserAlert useralerts)
        {
            try
            {
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from details in entitie.UserAlerts
                                 where details.Al_id == useralerts.Al_id
                                 select details);

                    if (query.Any())
                    {
                        entitie.UserAlerts.Remove(query.First());
                        entitie.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<UserAlert> GetAllUserAlerts()
        {
            try
            {
                List<UserAlert> userAlerts = new List<UserAlert>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.UserAlerts
                                 select info);

                    if (query.Any())
                        userAlerts = query.ToList();
                };
                return userAlerts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public UserAlert GetUserAlertsByID(string id)
        {
            try
            {
                UserAlert userAlerts = new UserAlert();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.UserAlerts
                                 where info.Al_id == id
                                 select info);

                    if (query.Any())
                        userAlerts = query.First();
                };
                return userAlerts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Area> GetAreabyUserA()
        {
            try
            {
                List<UserAlert> userAlerts = new List<UserAlert>();
                List<Area> areaList = new List<Area>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query1 = (from alert in entitie.UserAlerts select alert);
                    if (query1.Any())
                        userAlerts = query1.ToList();

                   foreach(UserAlert alert in userAlerts)
                    {
                        var query = (from info in entitie.Areas
                                     where info.A_id == alert.Area_id
                                      select info);
                        areaList.Add(query.First());

                    }
                     
                };
                return areaList;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Disaster_Type> GetDisasterbyUserA()
        {
            try
            {
                List<UserAlert> userAlerts = new List<UserAlert>();
                List<Disaster_Type> disasterList = new List<Disaster_Type>();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query1 = (from alert in entitie.UserAlerts select alert);
                    if (query1.Any())
                        userAlerts = query1.ToList();

                    foreach (UserAlert alert in userAlerts)
                    {
                        var query = (from info in entitie.Disaster_Type
                                     where info.D_id == alert.Disaster_id
                                     select info);
                        disasterList.Add(query.First());

                    }

                };
                return disasterList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public UserAlert GetMaxUserAlertsID()
        {
            try
            {
                UserAlert alert = new UserAlert();
                using (DisasterEntities entitie = new DisasterEntities())
                {
                    var query = (from info in entitie.UserAlerts
                                 orderby info.Al_id descending
                                 select info).Take(1);

                    if (query.Any())
                        alert = query.First();
                };
                return alert;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      
        #endregion

    }
}
