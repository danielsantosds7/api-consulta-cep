using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos
{
    public class ResponseGeneric<T> where T : class
    {
       public HttpStatusCode CodigoHttp { get; set; } 
       public T? DadosRetorno { get; set; }
       public ExpandoObject? ErroRetorno { get; set; }
       
    }
}