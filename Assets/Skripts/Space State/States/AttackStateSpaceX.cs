using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackStateSpaceX : SpaceXState
{
    public override void Attack()
    {
        Debug.Log("супер атака");
    }

    public override void Repair()
    {
        // ничего
    }

    public override void Salvage()
    {
        // ничего
    }

    public override void Upgrade()
    {
        // ничего
    }
}
