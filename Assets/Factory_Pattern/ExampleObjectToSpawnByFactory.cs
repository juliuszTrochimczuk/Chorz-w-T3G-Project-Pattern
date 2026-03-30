using UnityEngine;

public class ExampleObjectToSpawnByFactory : MonoBehaviour
{
    public GameObject SpawnedBy {  get; set; }

    private void Start() => 
        Debug.Log($"My name is {gameObject.name} and I was spawned by {SpawnedBy.name}");
}
