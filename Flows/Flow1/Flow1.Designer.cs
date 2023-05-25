using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.CSP.Workflow.Attributes;
using Bimser.CSP.Workflow.Interface.Api;
using Bimser.CSP.Workflow.Interface.Runtime;

namespace BCD_SATINALMATALEP.Flows
{
    [WorkflowIdentifier("03691684-105b-4369-950c-f502bbc2366e")]
    public partial class Flow1 : IWorkflowCode
    {           
        private FlowEvents FlowEvents;
        private FlowStart FlowStart1;
		private FlowEnd FlowEnd1;
		private FlowEnd FlowEnd2;
		private FlowPosition pzsAmir;
		private FlowPosition pzsGenelMudur;
		private FlowPosition pzsAkisBaslatan;
		private FlowPosition pzsSatinAlma;
		private FlowAssign Assignment1;
		private FlowCompare Compare1;
		private FlowState FlowState1;
		private FlowMail Notification1;
		private Variable vrTutar;
		private FlowNode NodeIn1;
		private FlowNode NodeOut1;
		private FlowDocument Document1;
		private FlowSetDocumentId SetDocumentId1;
		private FlowDeleteDocument DeleteDocument1;


        #region [ctor]
        
        public Flow1()
        {
            
        }

        #endregion

        #region [Initialize Data]

        private IRuntimeWorkflowData _workflowData;

        public void Initialize(IRuntimeWorkflowData workflowData)
        {
            // set workflow data
            _workflowData = workflowData;

            // initialize objects
            InitializeObjects();
        }

        #endregion

        #region [Initialize Objects]

        private void InitializeObjects()
        {
            // init flow objects            
            FlowStart1 = new FlowStart("FlowStart1", _workflowData);
			FlowEnd1 = new FlowEnd("FlowEnd1", _workflowData);
			FlowEnd2 = new FlowEnd("FlowEnd2", _workflowData);
			pzsAmir = new FlowPosition("pzsAmir", _workflowData);
			pzsGenelMudur = new FlowPosition("pzsGenelMudur", _workflowData);
			pzsAkisBaslatan = new FlowPosition("pzsAkisBaslatan", _workflowData);
			pzsSatinAlma = new FlowPosition("pzsSatinAlma", _workflowData);
			Assignment1 = new FlowAssign("Assignment1", _workflowData);
			Compare1 = new FlowCompare("Compare1", _workflowData);
			FlowState1 = new FlowState("FlowState1", _workflowData);
			Notification1 = new FlowMail("Notification1", _workflowData);
			vrTutar = new Variable("vrTutar", _workflowData);
			NodeIn1 = new FlowNode("NodeIn1", _workflowData);
			NodeOut1 = new FlowNode("NodeOut1", _workflowData);
			Document1 = new FlowDocument("Document1", _workflowData);
			SetDocumentId1 = new FlowSetDocumentId("SetDocumentId1", _workflowData);
			DeleteDocument1 = new FlowDeleteDocument("DeleteDocument1", _workflowData);


            // attach events to flow
            FlowEvents = new FlowEvents();
            

            // attach events to flow objects
            
        }

        #endregion
    }
}