using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointCounter : MonoBehaviour
{

    public int numberOfCheckpoints;

    public int triggeredCheckpoints;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }

    


    
}
