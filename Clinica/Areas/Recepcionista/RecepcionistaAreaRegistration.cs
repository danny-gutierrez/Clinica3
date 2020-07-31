using System.Web.Mvc;

namespace Clinica.Areas.Recepcionista
{
    public class RecepcionistaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Recepcionista";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Recepcionista_default",
                "Recepcionista/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Clinica.Areas.Recepcionista.Controllers" }
            );
        }
    }
}