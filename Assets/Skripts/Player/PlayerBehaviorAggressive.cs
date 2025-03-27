using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviorAggressive : IPlayerBehavior
{
    PlayerFunction pf = PlayerFunction.Instance;
    public void Enter()
    {
        Debug.Log(" Enter AGGRESSIVE ������� �����");
        pf.AgentStarted();
    }

    public void Exit()
    {
        Debug.Log(" Exit AGGRESSIVE �������� ����� ");
    }

    public void Update()
    {
        Debug.Log(" Update AGGRESSIVE ��� ����� ");
        pf.AgentGoingToRandomEat();
        
    }
}

