using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBehaviorActive : IPlayerBehavior
{
    PlayerFunction playerFunction = PlayerFunction.Instance;
    public void Enter()
    {
        playerFunction.AgentStarted();
        Debug.Log(" Enter Active");
    }

    public void Exit()
    {
        Debug.Log(" Exit Active");
    }

    public void Update()
    {
        Debug.Log(" update Active");

        playerFunction.AgentGoingToHouse();
        playerFunction.AgentStopped(playerFunction.House);


    }
}
