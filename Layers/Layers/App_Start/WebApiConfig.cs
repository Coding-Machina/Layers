using L.EF;
using Microsoft.AspNet.OData.Batch;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Layers
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.MapHttpAttributeRoutes();
            //config.MapODataServiceRoute("odata", "odataApi", GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            //config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            //config.EnsureInitialized();
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            config.MapODataServiceRoute("odata", "odataApi", GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            config.EnsureInitialized();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Batch>("Batch");

            var edmModel = builder.GetEdmModel();
            return edmModel;
        }
    }
}
