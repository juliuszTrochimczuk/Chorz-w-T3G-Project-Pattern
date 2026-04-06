using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update() => 
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);

    void OnCollisionEnter(Collision collision) =>
            BulletPool.Instance.ReturnToPool(this);
}
