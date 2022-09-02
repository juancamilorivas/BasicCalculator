using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BasicCalculator
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string superCool()
        {
            return "Hello World";
        }


        //suma
        [WebMethod]
        public decimal suma(decimal Valor_uno, decimal valor_dos)
        {
            decimal resultado = Valor_uno + valor_dos;
            return resultado;
        }

        //resta
        [WebMethod]
        public decimal resta(decimal ValorUno, decimal valorDos)
        {
            decimal resultadoResta = ValorUno - valorDos;
            return resultadoResta;
        }


        //multiplicacion
        [WebMethod]
        public decimal multiplicacion(decimal primerValor, decimal segundoValor)
        {
            decimal resultadomultiplicar = primerValor * segundoValor;
            return resultadomultiplicar;
        }

        //division
        [WebMethod]
        public decimal division(decimal primerNumero, decimal segundoNumero)
        {
            decimal resultadodivision = primerNumero / segundoNumero;
            return resultadodivision;
        }
    }
}
