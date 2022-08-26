using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace CustomModelBinder.Models
{
    public class CustomModel : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            var values = request.Headers.GetValues("WebGentle");
            return JsonConvert.DeserializeObject<Emp>(values.First());
        }
    }
}