using System;
using WorkflowCore.Interface;
using WorkflowCore.Primitives.EDM;

namespace WorkflowCore.JobSample.Steps
{
    public class DebugJob : Job
    {
        public override void BeforeEvent(IStepExecutionContext context)
        {
            Console.WriteLine("Before event");
        }

        public override void AfterEvent(IStepExecutionContext context)
        {
            Console.WriteLine("After event");
        }
    }
}