using UnityEngine;

public struct ExampleFactoryParams
{
    public ExampleObjectToSpawnByFactory Prefab { get; private set; }
    public Vector3 SpawnPos { get; private set; }
    public Quaternion SpawnRotation { get; private set; }
    public GameObject CreatedBy { get; private set; }

    public ExampleFactoryParams
        (ExampleObjectToSpawnByFactory prefab, Vector3 spawnPos, Quaternion spawnRotation, GameObject createdBy)
    {
        Prefab = prefab;
        SpawnPos = spawnPos;
        SpawnRotation = spawnRotation;
        CreatedBy = createdBy;
    }
}
