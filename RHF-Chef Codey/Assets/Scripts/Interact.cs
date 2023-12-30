using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour

{
    public Stove stove;

    public string triggerName = "";
    
    public GameObject breadPrefab;

    public GameObject heldItem;

    public string heldItemName;

    public GameObject breadOnPlate;

    public GameObject tomatoPrefab;

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
                PickupItem(breadPrefab, "breadSlice");
            }

            if (triggerName == "tomato")
            {
                PickupItem(tomatoPrefab, "Tomato");
            }

            if (triggerName == "Stove")
            {
                print("I'm at the stove!");
                if (heldItemName == "breadSlice")
                {
                    print("ready to toast!");
                    stove.ToastBread();
                    PlaceHeldItem();

                }
                else
                {
                    PickupItem(breadPrefab, "toastSlice");
                    stove.CleanStove();
                    print("Codey needs to get the bread!");
                }
            }

            if (triggerName == "Receivers")
            {
                PlaceHeldItem();
               breadOnPlate.SetActive(true);
            }

        }
    }

    private void PlaceHeldItem()
    {
        Destroy(heldItem);
        heldItemName = "";
    }

    private void PickupItem(GameObject prefab, string name)
    {
        heldItem = Instantiate(prefab, transform, false);
        heldItem.transform.localPosition = new Vector3(0, 2, 2);
        heldItemName = name;
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
