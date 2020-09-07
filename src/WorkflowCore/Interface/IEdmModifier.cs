using System;
using System.Collections;
using System.Linq.Expressions;
using WorkflowCore.Primitives;
using WorkflowCore.Primitives.EDM;

namespace WorkflowCore.Interface
{
    public interface IEdmModifier<TData, TStepBody>
        where TStepBody : IStepBody
    {
        IStepBuilder<TData, Foreach> Job<TJob>(Expression<Func<TData, IEnumerable>> collection,
            Expression<Func<TData, bool>> runParallel) where TJob : Job;

        IStepBuilder<TData, Foreach> Notification<TNotification>(Expression<Func<TData, IEnumerable>> collection) where TNotification : Notification;
    }
}