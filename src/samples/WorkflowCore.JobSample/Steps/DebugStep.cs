using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.JobSample.Steps
{
    public class DebugStep : StepBody
    {
        public string Message { get; set; }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine($"Debug step: {Message}");
            return ExecutionResult.Next();
        }
    }
}