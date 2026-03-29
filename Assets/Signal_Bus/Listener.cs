using UnityEngine;

public class Listener : MonoBehaviour
{
    private void Start() =>
        SignalBus.Instance.SubscribeSignal("Event1", () => Debug.Log("I love marakasas"));

    private void Update() => SignalBus.Instance.FireSignal("Event1");
}
