using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Services3.Security.Tokens;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Xml;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace FactISG
{
    public class PasswordDigestMessageInspector : IClientMessageInspector
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public PasswordDigestMessageInspector(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            return;
        }

        public object BeforeSendRequest(ref Message request, System.ServiceModel.IClientChannel channel)
        {
            UsernameToken token = new UsernameToken(UserName, Password, PasswordOption.SendPlainText);

            XmlElement securityToken = token.GetXml(new XmlDocument());
            // Modificamos el XML Generado.
            var nodo = securityToken.GetElementsByTagName("wsse:Nonce").Item(0);
            nodo.RemoveAll();

            MessageHeader securityHeader = MessageHeader.CreateHeader("Security",
                "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd",
                securityToken, false);
            request.Headers.Add(securityHeader);
            return Convert.DBNull;
        }
    }


    public class PasswordDigestBehavior : IEndpointBehavior
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public PasswordDigestBehavior(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public void AddBindingParameters(ServiceEndpoint endPoint, BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyClientBehavior(ServiceEndpoint endPoint, ClientRuntime clientRuntime)
        {
            clientRuntime.ClientMessageInspectors.Add(new PasswordDigestMessageInspector(UserName, Password));
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endPoint, EndpointDispatcher endpointDispatcher)
        {
            return;
        }

        public void Validate(ServiceEndpoint endPoint)
        {
            return;
        }


    }
}
