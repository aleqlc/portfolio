using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MemoEngine
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            //자바스크립트 변수명 권장 규칙에 따라
            //Web API의 결과값을 소문자로 시작할 수 있도록 설정
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =
                new Newtonsoft.Json.Serialization.
                    CamelCasePropertyNamesContractResolver();

            //Web API 경로
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
