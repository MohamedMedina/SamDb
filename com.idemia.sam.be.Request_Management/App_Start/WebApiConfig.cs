using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Common;
using ApplicationBlocks.Layers;

namespace com.idemia.sam.be.Request_Management
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
                .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            GlobalConfiguration.Configuration.Formatters
                .Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
        public static void OpenDBConnection()
        {
            try
            {
                DataBase _database = new DataBase();
                DbConnection _dbconnection = _database.CreateConnection(_database.GetConnectionString());

                _dbconnection.Open();
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}
