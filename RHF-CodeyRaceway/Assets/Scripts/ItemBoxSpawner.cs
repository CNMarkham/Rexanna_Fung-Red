using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{

    public GameObject[] SPs;

    public GameObject itemBox;

    // Start is called before the first frame update
    void Start()
    {
         for (int i = 0; i < SPs.Length; i++)
        {
           GameObject itemBoxClone = Instantiate(itemBox,SPs[i].transform.position,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
