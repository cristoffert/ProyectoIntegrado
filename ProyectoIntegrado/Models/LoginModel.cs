using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoIntegrado.Models
{ 
    public class LoginModel
    {
        public string Usuario { get; set; }

        public string Pass { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}