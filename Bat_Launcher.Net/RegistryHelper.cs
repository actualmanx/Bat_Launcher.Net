namespace Bat_Launcher.Net
{

    public class RegistryHelper
    {
        private static readonly string BaseRegistryKey = @"Software\Acid\" + (Application.ProductName?.ToString() ?? "DefaultProductName");

        public static void Write(string subKey, string valueName, object value)
        {
            using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(BaseRegistryKey);
            if (registryKey != null)
            {
                using RegistryKey subKeyRef = registryKey.CreateSubKey(subKey);
                subKeyRef?.SetValue(valueName, value);
            }
        }

        public static object? Read(string subKey, string valueName)
        {
            using RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(BaseRegistryKey);
            if (registryKey != null)
            {
                using RegistryKey? subKeyRef = registryKey.OpenSubKey(subKey);
                return subKeyRef?.GetValue(valueName);
            }
            return null;
        }

        public static void Delete(string subKey, string valueName)
        {
            using RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(BaseRegistryKey, true);
            if (registryKey != null)
            {
                using RegistryKey? subKeyRef = registryKey.OpenSubKey(subKey, true);
                subKeyRef?.DeleteValue(valueName, false);
            }
        }
    }
}