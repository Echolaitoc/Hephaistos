using UnityEngine;

public static class Hephaistos
{
    public static Object InstantiatePrefab(Object original)
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            return UnityEditor.PrefabUtility.InstantiatePrefab(original);
        }
#endif
        return GameObject.Instantiate(original);
    }

    public static void Destroy(Object obj)
    {
#if UNITY_EDITOR
        if (!Application.isPlaying)
        {
            UnityEngine.Object.DestroyImmediate(obj);
            return;
        }
#endif
        UnityEngine.Object.Destroy(obj);
    }
}
