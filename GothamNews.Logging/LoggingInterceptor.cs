using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GothamNews.Logging
{
    public class LoggingInterceptor:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var serializer = new JavaScriptSerializer();
            var parametersJson = serializer.Serialize(invocation.Arguments);

            string filename = "logfile_" + DateTime.Now.ToString().Replace(":", "_").Replace(".", "") + ".txt";

            string path = AppDomain.CurrentDomain.BaseDirectory + filename;
            // create a writer and open the file
            TextWriter tw = new StreamWriter(path);

            tw.WriteLine("Request of " + invocation.Method.Name + " is " + parametersJson,filename);

            invocation.Proceed();

            var returnValueJson = serializer.Serialize(invocation.ReturnValue);

            tw.WriteLine("Response of " + invocation.Method.Name + " is: " + invocation.ReturnValue,filename);

            // close the stream
            tw.Close();
        }


    }
}
