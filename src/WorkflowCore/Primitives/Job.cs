using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.Primitives
{
    public abstract class Job : StepBody
    {
        public object Performer { get; set; }

        public abstract override ExecutionResult Run(IStepExecutionContext context);
    }
}