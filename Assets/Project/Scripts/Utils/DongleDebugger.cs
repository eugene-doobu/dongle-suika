using UnityEngine;

namespace DongleSuika
{
    public class DongleDebugger
    {
        public static void Log(string message)
        {
            Debug.Log(message);
        }

        public static void Log(string header, string message)
        {
            Debug.Log($"[{header}]: {message}");
        }

        public static void Log(string header, string message, Object context)
        {
            Debug.Log($"[{header}]: {message}", context);
        }

        public static void LogWarning(string message)
        {
            Debug.LogWarning(message);
        }

        public static void LogWarning(string header, string message)
        {
            Debug.LogWarning($"[{header}]: {message}");
        }

        public static void LogWarning(string header, string message, Object context)
        {
            Debug.LogWarning($"[{header}]: {message}", context);
        }

        public static void LogError(string message)
        {
            Debug.LogError(message);
        }

        public static void LogError(string header, string message)
        {
            Debug.LogError($"[{header}]: {message}");
        }

        public static void LogError(string header, string message, Object context)
        {
            Debug.LogError($"[{header}]: {message}", context);
        }
    }
}
