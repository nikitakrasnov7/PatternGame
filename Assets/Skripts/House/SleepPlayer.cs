using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.LogWarning("стой сукааа");
            other.GetComponent<Player>().sleepTime += 15f;
            other.GetComponent<Player>().isSleep = true;
            other.GetComponent<Player>().SetBehaviorIdle();
        }

    }
}
