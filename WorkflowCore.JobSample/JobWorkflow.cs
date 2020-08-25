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
            builder.StartWith<DebugStep>().Input(step => step.Message, data => "StartStep");
        }
    }

    public class JobData
    {
        public string debugString { get; set; }
    }
}