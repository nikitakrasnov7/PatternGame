using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private  float eatTime = 5f;
    public  float sleepTime = 15f;

    private Dictionary<Type, IPlayerBehavior> behaviorMap;
    private IPlayerBehavior behaviorCurrent;

    public GameDataSO gameData;

    private void Start()
    {
        this.InitBehaviors();
        this.SetBehaviorByDefault();
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

    private void Timer()
    {

        eatTime = eatTime >= 0 ? eatTime - Time.deltaTime : 0;
        sleepTime = sleepTime >= 0 ? sleepTime - Time.deltaTime : 0;

    }
    private void AddingTimeToSleep()
    {
        sleepTime += 20f;
    }
    private void AddingTimeToEat()
    {
        eatTime += 10f;
    }

    public bool isSleep = true;

    private void Update()
    {
        Timer();

        //if (eatTime < 2f)
        //{
        //    this.SetBehaviorIAggressive();
        //}
        if (sleepTime < 5f)
        {
            if (isSleep)
            {
                isSleep = false;
                this.SetBehaviorActive();

            }

        }




        if (this.behaviorCurrent != null)
        {
            this.behaviorCurrent.Update();
        }
    }



}
