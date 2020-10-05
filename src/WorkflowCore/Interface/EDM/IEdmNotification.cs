using System;

namespace WorkflowCore.Interface.EDM
{
    public interface IEdmNotification
    {
        Guid PerformerId { get; set; }
        Guid JobId { get; set; }
    }
}