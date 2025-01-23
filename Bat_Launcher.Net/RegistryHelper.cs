using Microsoft.Win32;

namespace Bat_Launcher.Net
{

    public class RegistryHelper
    {
        public static void Write(string key, string subKey, string valueName, object value)
        {
            using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(key);
            if (registryKey != null)
            {
                using RegistryKey subKeyRef = registryKey.CreateSubKey(subKey);
                subKeyRef?.SetValue(valueName, value);
            }
        }

        public static object? Read(string key, string subKey, string valueName)
        {
            using RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(key);
            if (registryKey != null)
            {
                using RegistryKey? subKeyRef = registryKey.OpenSubKey(subKey);
                return subKeyRef?.GetValue(valueName);
            }
            return null;
        }

        public static void Delete(string key, string subKey, string valueName)
        {
            using RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(key, true);
            if (registryKey != null)
            {
                using RegistryKey? subKeyRef = registryKey.OpenSubKey(subKey, true);
                subKeyRef?.DeleteValue(valueName, false);
            }
        }
    }
}