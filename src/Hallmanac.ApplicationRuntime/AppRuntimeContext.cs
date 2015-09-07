using System.Collections.Concurrent;


namespace Hallmanac.ApplicationRuntime
{
    public class AppRuntimeContext : IAppRuntimeContext
    {
        public ConcurrentDictionary<string, object> Environment { get; } = new ConcurrentDictionary<string, object>();


        public T Get<T>(string key)
        {
            object value;
            return Environment.TryGetValue(key, out value) ? (T)value : default(T);
        }


        public IAppRuntimeContext Set<T>(string key, T value)
        {
            Environment.AddOrUpdate(key, value, (s, o) => value);
            return this;
        }


        public IAppRuntimeContext Remove<T>(string key)
        {
            object value;
            Environment.TryRemove(key, out value);
            return this;
        }
    }
}