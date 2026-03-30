using UnityEngine;

public abstract class Factory<T, Object, Param> : Singleton<T> where T : MonoBehaviour
{
    public abstract Object Create(Param param);
}