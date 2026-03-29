using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    protected override GameManager CreateInstance() => this;

    //Example method
    public void SayHi() => Debug.Log("Hello");
}
