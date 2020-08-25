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
        IStepBuilder<TData, Foreach> Job<TStep>(Expression<Func<TData, IEnumerable>> collection,
            Expression<Func<TData, bool>> runParallel) where TStep : Job;

        IStepBuilder<TData, Foreach> Notification<TStep>(Expression<Func<TData, IEnumerable>> collection,
            Expression<Func<TData, bool>> runParallel) where TStep : Notification;
    }
}