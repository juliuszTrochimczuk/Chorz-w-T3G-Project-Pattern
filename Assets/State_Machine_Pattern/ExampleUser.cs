using System.Collections.Generic;
using UnityEngine;

public class ExampleUser : MonoBehaviour
{
    public StateMachine StateMachine { get; private set; }

    //Example variable used later
    [SerializeField] private Transform destinationPoint;
    public Transform DestinationPoint => destinationPoint;

    [SerializeField] private float speed;
    public float Speed => speed;

    private void Awake()
    {
        StateMachine = new(
            new Dictionary<System.Enum, State>
            {
               {  ExampleStatesId.Idle, new ExampleIdleState(this) },
               {  ExampleStatesId.Walking, new ExampleWalkingState(this) }
            },
            ExampleStatesId.Walking
        );
    }

    private void Start() => StateMachine.OnStart();

    private void Update() => StateMachine.OnUpdate();

    private void OnDestroy() => StateMachine.OnEnd();
}
