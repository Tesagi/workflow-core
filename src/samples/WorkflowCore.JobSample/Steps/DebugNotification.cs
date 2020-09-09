using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;
using WorkflowCore.Primitives.EDM;

namespace WorkflowCore.JobSample.Steps
{
    public class DebugNotification : Notification
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine($"Notification for: {Performer}");
            return ExecutionResult.Next();
        }
    }
}