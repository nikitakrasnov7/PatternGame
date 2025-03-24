using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorAggressive : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log(" Enter AGGRESSIVE ");
    }

    public void Exit()
    {
        Debug.Log(" Exit AGGRESSIVE ");
    }

    public void Update()
    {
        Debug.Log(" Update AGGRESSIVE ");
    }
}

