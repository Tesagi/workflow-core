using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.Primitives.EDM
{
    public abstract class Job : StepBody
    {
        public object Performer { get; set; }

        public abstract override ExecutionResult Run(IStepExecutionContext context);
    }
}