using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public Player player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            player.SetBehaviorActive();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            player.SetBehaviorIAggressive();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            player.SetBehaviorIdle();
        }
    }
}
