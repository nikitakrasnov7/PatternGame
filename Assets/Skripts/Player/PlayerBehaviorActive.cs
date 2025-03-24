using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBehaviorActive : IPlayerBehavior
{
    public void Enter()
    {
        Debug.Log("хочу спааать");
    }

    public void Exit()
    {
        Debug.Log(" лег спать");
    }

    public void Update()
    {
        //if (GameDataSO.player.GetComponent<NavMeshAgent>() != null)
        //{
        //    if (GameDataSO.house != null)
        //    {
        //        GameObject house = GameDataSO.house.gameObject;
        //        NavMeshAgent agent = GameDataSO.player.GetComponent<NavMeshAgent>();
        //        agent.destination = house.transform.position;

                

        //    }


        //}

    }
}
