using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace BCD_SATINALMATALEP.Forms
{
    [Route("api/TalepForm/[action]")]
    [Produces("application/json")]
    public class TalepFormController : BaseFormController<TalepForm>
    {
        public TalepFormController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "TalepForm API Controller is ok";            
        }
    }
}