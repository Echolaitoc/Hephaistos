using UnityEngine;

public static class Hephaistos
{
    public static Object InstantiatePrefab(Object original)
    {
#if UNITY_EDITOR
        return UnityEditor.PrefabUtility.InstantiatePrefab(original);
#else
        return Instantiate(original);
#endif
    }
}
