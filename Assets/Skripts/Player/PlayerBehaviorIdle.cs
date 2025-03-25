

using UnityEngine;

public class PlayerBehaviorIdle : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log(" Enter IDLE ");
        PlayerFunction.Instance.AgentStarted();
    }

    public void Exit()
    {
        Debug.Log(" Exit IDLE ");
    }

    public void Update()
    {
        Debug.Log(" Update IDLE ");

        PlayerFunction.Instance.RandomGoingAgent();
    }
}
