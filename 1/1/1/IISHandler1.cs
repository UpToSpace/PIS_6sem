using System;
using System.Linq;
using System.Web;

namespace _1
{
    public class IISHandler1 : IHttpHandler
    {
        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //разместите здесь вашу реализацию обработчика.
            String parmA = context.Request.Params.Get("ParmA");
            String parmB = context.Request.Params.Get("ParmB");
            String extencion = context.Request.FilePath.Split('.').LastOrDefault();
            String method = context.Request.HttpMethod.ToUpper();
            String response = $"{method}-Http-{extencion}:ParmA = {parmA},ParmB = {parmB}";
            context.Response.Write(response);
        }
    }
}
