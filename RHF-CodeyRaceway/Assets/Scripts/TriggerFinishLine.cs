using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{

    public CheckPointCounter checkpointTracker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            print("You Win");

        }

        if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
        {
            print("You Win!");
        }
    }
}
