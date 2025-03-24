using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private float eatTime = 5f;
    private float sleepTime = 5f;

    private Dictionary<Type, IPlayerBehavior> behaviorMap;
    private IPlayerBehavior behaviorCurrent;

    public GameDataSO gameData;
    private void Start()
    {
        this.InitBehaviors();
        this.SetBehaviorByDefault();

        //gameData.player = gameObject;
        //gameData.house = GameObject.FindGameObjectWithTag("House").gameObject;
        GameObject[] eats = GameObject.FindGameObjectsWithTag("Eats");
        for (int i = 0; i < eats.Length; i++)
        {
            gameData.eats.Add(eats[i]);
        }


    }

    private void InitBehaviors()
    {
        behaviorMap = new Dictionary<Type, IPlayerBehavior>();
        this.behaviorMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive();
        this.behaviorMap[typeof(PlayerBehaviorAggressive)] = new PlayerBehaviorAggressive();
        this.behaviorMap[typeof(PlayerBehaviorIdle)] = new PlayerBehaviorIdle();
    }

    private void SetBehavior(IPlayerBehavior newBehavior)
    {
        if (this.behaviorCurrent != null)
        {
            this.behaviorCurrent.Exit();
        }

        this.behaviorCurrent = newBehavior;
        this.behaviorCurrent.Enter();

    }
    private void SetBehaviorByDefault()
    {
        var behaviorByDefault = this.GetBehavior<PlayerBehaviorIdle>();
        this.SetBehavior(behaviorByDefault);
    }

    public void SetBehaviorIdle()
    {
        var behavior = this.GetBehavior<PlayerBehaviorIdle>();
        this.SetBehavior(behavior);
    }

    public void SetBehaviorActive()
    {
        var behavior = this.GetBehavior<PlayerBehaviorActive>();
        this.SetBehavior(behavior);
    }

    public void SetBehaviorIAggressive()
    {
        var behavior = this.GetBehavior<PlayerBehaviorAggressive>();
        this.SetBehavior(behavior);
    }

    private IPlayerBehavior GetBehavior<T>() where T : IPlayerBehavior
    {
        var type = typeof(T);
        return this.behaviorMap[type];
    }

    private void Update()
    {
        eatTime -= 0.01f;
        sleepTime -= 0.01f;

        //float distation = Vector3.Distance(gameObject.transform.position, GameDataSO.house.transform.position);
        //if (distation < 2) 
        //{
        //    sleepTime += 10f;
        //}


        if (eatTime < 2f)
        {
            this.SetBehaviorIAggressive();
        }
        if (sleepTime < 5f)
        {
            this.SetBehaviorActive();
        }
        if ( sleepTime > 5f)
        {
            this.SetBehaviorIdle();
        }

        

        if (this.behaviorCurrent != null)
        {
            this.behaviorCurrent.Update();
        }
    }

}
