using PizzariaRioClaro.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PizzariaRioClaro.Filters
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext FilterContext)
        {
            if (FilterContext.Controller.GetType() == typeof(PessoaController))
                return;
            bool pessoa = FilterContext.ActionDescriptor.ControllerDescriptor.ControllerName == "Pessoa";
            bool autentica = FilterContext.ActionDescriptor.ActionName == "Autentica";
            bool login = FilterContext.ActionDescriptor.ActionName == "Login";

            object usuario = FilterContext.HttpContext.Session["pessoalogada"];

            if (usuario == null && !(pessoa && login) && !(pessoa && autentica))
            {
                FilterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Pessoa", action = "Login" }
                        )
                    );
            }
        }
    }
}