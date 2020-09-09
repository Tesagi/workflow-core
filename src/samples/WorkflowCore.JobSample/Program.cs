using System;
using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.Interface;
using WorkflowCore.JobSample.Steps;

namespace WorkflowCore.JobSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();

            //start the workflow host
            var host = serviceProvider.GetService<IWorkflowHost>();
            host.RegisterWorkflow<JobWorkflow, JobData>();
            host.Start();

            host.StartWorkflow("JobWorkflow");

            Console.ReadLine();
            host.Stop();
        }

        private static IServiceProvider ConfigureServices()
        {
            //setup dependency injection
            IServiceCollection services = new ServiceCollection();
            services.AddLogging();
            services.AddWorkflow();
            //services.AddWorkflow(x => x.UseMongoDB(@"mongodb://localhost:27017", "workflow"));
            services.AddTransient<DebugStep>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}