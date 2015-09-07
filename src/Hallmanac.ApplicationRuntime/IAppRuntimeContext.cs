using System.Collections.Concurrent;


namespace Hallmanac.ApplicationRuntime
{
    public interface IAppRuntimeContext
    {
        ConcurrentDictionary<string, object> Environment { get; }


        T Get<T>(string key);


        IAppRuntimeContext Set<T>(string key, T value);


        IAppRuntimeContext Remove<T>(string key);
    }
}