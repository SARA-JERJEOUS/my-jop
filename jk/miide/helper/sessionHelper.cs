using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;

namespace miide.helper
{
        public class SessionMnger
        {

                readonly ISession _session;
                public SessionMnger(IHttpContextAccessor http)
                {
                        _session = http.HttpContext.Session;
                }

                public string FullName
                {
                        get { return _session.GetString("Name"); }
                        set { _session.SetString("Name", value); }
                }

                public bool IsAuthorized
                {
                        get
                        {
                                return _session.GetString("Name") != null;
                        }

                }

                public bool IsAdmin
                {
                        get
                        {
                                bool.TryParse(_session.GetString("IsAdmin"), out bool isAdmin);
                                return isAdmin;
                        }
                        set
                        {
                                _session.SetString("IsAdmin", value.ToString());
                        }
                }

                public void ClearSession()
                {
                        _session.Clear();
                }

                /*   public static bool isuser
                   {
                           get
                           {
                                   if (HttpContext.Session.["Isuser"] == null)
                                           return false;
                                   return (bool)HttpContext.Current.Session["Isuser"];
                           }
                           set
                           {
                                   HttpContext.Current.Session["Isuser"] = value;
                           }
                   }*/
        }
}
