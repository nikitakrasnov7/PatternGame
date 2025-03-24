using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpaceX : MonoBehaviour
{
    public State _state;
    public SpaceXState State;
    private void Start()
    {
        State = new AttackStateSpaceX();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            State = new AttackStateSpaceX();

            State.Attack();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            State = new RepairStateSpaceX();

            State.Repair();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            State = new UpgradeStateSpaceX();

            State.Upgrade();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            State = new SalvageStateSpaceX();

            State.Salvage();
        }

    }
}
