using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    [SerializeField] private bool isDestructableOnLoad;
    
    private void Awake()
    {
        if (Instance != null)
            Destroy(Instance);

        Instance = CreateInstance();

        if (!isDestructableOnLoad)
            DontDestroyOnLoad(Instance);
    }

    protected abstract T CreateInstance();
}
