using System;
using System.Linq.Expressions;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.Primitives.EDM
{
    public abstract class Job : StepBody
    {
        public object Performer { get; set; }

        public sealed override ExecutionResult Run(IStepExecutionContext context)
        {
            if (!context.ExecutionPointer.EventPublished)
            {
                BeforeEvent(context);
                return ExecutionResult.WaitForEvent(context.Workflow.Id, context.ExecutionPointer.Id, DateTime.UtcNow);
            }

            AfterEvent(context);
            return ExecutionResult.Next();
        }

        public abstract void BeforeEvent(IStepExecutionContext context);

        public abstract void AfterEvent(IStepExecutionContext context);
    }
}