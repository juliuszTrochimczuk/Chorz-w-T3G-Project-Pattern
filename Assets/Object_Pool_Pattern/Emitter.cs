using System.Collections;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    [SerializeField] private float spawnInterval;

    private void Start() => StartCoroutine(Emit());

    private IEnumerator Emit()
    {
        WaitForSeconds interval = new(spawnInterval);
        while (true)
        {
            Bullet bullet = BulletPool.Instance.GetFromPool();
            if (bullet != null)
                bullet.transform.position = transform.position;
            yield return interval;
        }
    }
}