using System;
using System.Threading.Tasks;


namespace Hallmanac.ApplicationRuntime
{
    public interface IAppRuntimeController
    {
        IAppRuntimeController AddToPipeline(Func<IAppRuntimeContext, Func<Task>, Task> pipelineFunc);
    }
}