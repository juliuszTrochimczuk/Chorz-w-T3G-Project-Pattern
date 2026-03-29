using System;
using AYellowpaper.SerializedCollections;
using UnityEngine;
using UnityEngine.Events;

public class SignalBus : Singleton<SignalBus>
{
    //We use SerializedDictionary, cause regular Dictionary is not serialized by Unity :(
    [SerializeField] private SerializedDictionary<string, UnityEvent> signals;
    
    protected override SignalBus CreateInstance() => this;

    public void FireSignal(string key) => signals[key].Invoke();

    public void SubscribeSignal(string key, UnityAction action) => signals[key].AddListener(action);
    public void UnsubscribeSignal(string key, UnityAction action) => signals[key].RemoveListener(action);

    public void CreateNewSignal(string key)
    {
        if (!signals.ContainsKey(key))
            throw new ArgumentException($"Signal bus already contains such key: {key}");
        signals.Add(key, new UnityEvent());
    }
}
