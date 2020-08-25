using System.Collections.Generic;
using WorkflowCore.Interface;
using WorkflowCore.JobSample.Steps;

namespace WorkflowCore.JobSample
{
    public class JobWorkflow : IWorkflow<JobData>
    {
        public string Id => nameof(JobWorkflow);
        public int Version => 1;

        public void Build(IWorkflowBuilder<JobData> builder)
        {
            builder.StartWith<DebugStep>()
                        .Input(step => step.Message, data => "StartStep")
                        .Job<DebugJob>(data => data.Performers, data => true)
                        .Then<DebugStep>()
                        .Input(step => step.Message, data => "EndStep");
        }
    }

    public class JobData
    {
        public string debugString { get; set; }
        public List<int> Performers { get; set; } = new List<int> { 1, 2, 3, 4, 5 };
    }
}