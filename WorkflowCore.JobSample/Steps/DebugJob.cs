using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;
using WorkflowCore.Primitives.EDM;

namespace WorkflowCore.JobSample.Steps
{
    public class DebugJob : Job
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine($"Job for performer: {Performer}");
            return ExecutionResult.Next();
        }
    }
}