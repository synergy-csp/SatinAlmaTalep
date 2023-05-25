using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace BCD_SATINALMATALEP.Flows
{
    [Route("api/Flow1/[action]")]
    [Produces("application/json")]
    public class Flow1Controller : BaseFlowController
    {
        private readonly string _flowFileName = "Flow1";

        public Flow1Controller(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
            : base(iocManager, workflowController, workflowRegistry, definitionLoader)
        {
            FlowFileName = _flowFileName;
        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Flow1 API Controller is ok";
        }
    }
}