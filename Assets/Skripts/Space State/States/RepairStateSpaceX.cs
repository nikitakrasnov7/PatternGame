
using UnityEngine;

public class RepairStateSpaceX : SpaceXState
{
    public override void Attack()
    {
        // ничего
    }

    public override void Repair()
    {
        Debug.Log("супер репаир");
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
