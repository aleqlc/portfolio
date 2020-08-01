using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFcrudWithJAPI
{
    // 참고: "리팩터링" 메뉴에서 "이름 바꾸기" 명령을 사용하여 코드 및 config 파일에서 인터페이스 이름 "IServiceProduct"을 변경할 수 있습니다.
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        [WebInvoke(Method ="GET", UriTemplate ="findall",ResponseFormat =
            WebMessageFormat.Json)]
        List<Product> findAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{id}", ResponseFormat =
            WebMessageFormat.Json)]
        Product find(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat =
            WebMessageFormat.Json, RequestFormat =WebMessageFormat.Json)]
        bool create(Product product);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat =
            WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool edit(Product product);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat =
            WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool delete(Product product);
    }
}
