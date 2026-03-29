using UnityEngine;

public class ExampleIdleState : State
{
    private int requestedTime;

    public ExampleIdleState(MonoBehaviour onwer) : base(onwer)
    {
    }

    public override bool StateCondition()
    {
        requestedTime++;
        Debug.Log($"You've regested walking {requestedTime} times");
        //HERE IS RANDOM CHECK TO SHOWCASE THIS
        return requestedTime >= 3;
    }


    public override void OnStart() => Debug.Log($"My name is: {onwer.name} and I'm idling");
}
