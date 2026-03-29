using UnityEngine;

public class ExampleWalkingState : State
{
    private Vector3 walkingDir;
    private Vector3 checkPos;
    private ExampleUser exampleUser;

    public ExampleWalkingState(MonoBehaviour onwer) : base(onwer)
    {
    }

    public override bool StateCondition() => true;

    public override void OnStart()
    {
        if (exampleUser == null)
            exampleUser = onwer as ExampleUser;

        checkPos = new(exampleUser.DestinationPoint.position.x, exampleUser.transform.position.y, exampleUser.DestinationPoint.position.z);
        walkingDir = (checkPos - exampleUser.transform.position).normalized;
    }

    public override void OnUpdate()
    {
        exampleUser.transform.Translate(walkingDir * exampleUser.Speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(checkPos, exampleUser.transform.position) < 0.2f)
            exampleUser.StateMachine.TryChangeState(ExampleStatesId.Idle);
    }

    public override void OnEnd() => Debug.Log($"My name is: {onwer.name} and I stopped walking");
}
