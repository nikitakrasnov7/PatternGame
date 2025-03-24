using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalvageStateSpaceX : SpaceXState
{
    public override void Attack()
    {
        // ничего
    }

    public override void Repair()
    {
        // ничего
    }

    public override void Salvage()
    {
        Debug.Log("супер салваге");
    }

    public override void Upgrade()
    {
        // ничего
    }
}
