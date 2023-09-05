using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class checkpointCollision : MonoBehaviour
{

    public bool didCollide;

    // Start is called before the first frame update

    void Start()
    {
        didCollide = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player" && didCollide == false)
        {
            didCollide = true;
        }

    }

}
