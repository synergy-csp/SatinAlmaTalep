using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace BCD_SATINALMATALEP.Forms
{
    [Route("api/Form1/[action]")]
    [Produces("application/json")]
    public class Form1Controller : BaseFormController<Form1>
    {
        public Form1Controller(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Form1 API Controller is ok";            
        }
    }
}