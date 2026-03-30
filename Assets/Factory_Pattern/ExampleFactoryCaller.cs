using System.Collections;
using UnityEngine;

public class ExampleFactoryCaller : MonoBehaviour
{
    [SerializeField] private ExampleObjectToSpawnByFactory prefab;

    [SerializeField] private float objectSpawnInterval = 1.5f;
    [SerializeField] private Vector3 spawnArea;

    private void Start() => StartCoroutine(FactoryCaller());

    private IEnumerator FactoryCaller()
    {
        WaitForSeconds spawnInterval = new(objectSpawnInterval);
        while (true)
        {
            Vector3 randomPosition = transform.position +  new Vector3(
                    Random.Range(-spawnArea.x, spawnArea.x),
                    0.0f, 
                    Random.Range(-spawnArea.z, spawnArea.z)
                );
            ExampleFactory.Instance.Create(new(prefab, randomPosition, Quaternion.identity, gameObject));
            yield return spawnInterval;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(transform.position, spawnArea);
    }
}
