

using UnityEngine;

public class PlayerBehaviorIdle : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log(" Enter IDLE ");
    }

    public void Exit()
    {
        Debug.Log(" Exit IDLE ");
    }

    public void Update()
    {
        Debug.Log(" Update IDLE ");
    }
}
