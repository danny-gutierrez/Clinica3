﻿using System.Web.Mvc;

namespace Clinica.Areas.Doctor
{
    public class DoctorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Doctor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Doctor_default",
                "Doctor/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Clinica.Areas.Doctor.Controllers" }
            );
        }
    }
}