using System;
using System.Reflection;

namespace StatEv.Classes
{
    public class GlobalHelper
    {
        private static Version _Version;
        public static string GetVersion(int fieldCount)
        {
            if (_Version == null)
                _Version = Assembly.GetAssembly(typeof(GlobalHelper)).GetName().Version;

            return _Version.ToString(fieldCount);
        }
    }
}
