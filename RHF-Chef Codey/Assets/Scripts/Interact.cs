using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour

{

    public string triggerName = "";

    public GameObject breadPrefab;

    public GameObject heldItem;

    public string heldItemName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "bread (4)")
            {
                heldItem = Instantiate(breadPrefab, transform, false);
                heldItem.transform.localPosition = new Vector3(0, 2, 2);
                heldItemName = "breadSlice";
            }

            if (triggerName == "Stove")
            {
                print("I'm at the stove!");
                if (heldItemName == "breadSlice")
                {
                    print("ready to toast!");
                }
                else
                {
                    print("Codey needs to get the bread!");
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}
