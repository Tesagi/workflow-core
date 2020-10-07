using System;

namespace WorkflowCore.Interface.EDM
{
    public interface IEdmJob
    {
        object PerformerId { get; set; }
    }
}