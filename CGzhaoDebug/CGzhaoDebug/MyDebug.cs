using UnityEngine;

public static class MyDebug
{
    public static bool isDebug = true;

    public static void Log(string str)
    {
        if (!isDebug) return;
        Debug.Log(str);
    }

    public static void LogNormal(string str)
    {
        if (!isDebug) return;
        Debug.Log(string.Format("<color=yellow>{0}</color>", str));
    }
}