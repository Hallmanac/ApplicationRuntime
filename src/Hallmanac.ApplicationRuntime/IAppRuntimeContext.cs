using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;


namespace Hallmanac.ApplicationRuntime
{
    public interface IAppRuntimeContext
    {
        IDictionary<string, object> Environment { get; }


        T Get<T>(string key);


        IAppRuntimeContext Set<T>(string key, T value);
    }
}