using UnityEngine;

public class Printer : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.SayHi();
    }
}
