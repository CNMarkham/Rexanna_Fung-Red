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

    public GameObject boiledTomatoPrefab;

    public GameObject TomatoOnPlate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (heldItemName == "") 
            {
                if (triggerName == "bread (4)")
                {
                    PickupItem(breadPrefab, "breadSlice");
                }
                else if (triggerName == "tomato")
                {
                    PickupItem(tomatoPrefab, "Tomato");
                }
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
                else if (heldItemName == "Tomato")
                {
                    stove.BoilTomatoes();
                    PlaceHeldItem();
                }
                else
                {
                    if (stove.cookedFood == "toast")
                    {
                        PickupItem(breadPrefab, "toastSlice");
                        stove.CleanStove();
                    }

                    if (stove.cookedFood == "boiledTomato")
                    {
                        PickupItem(boiledTomatoPrefab, "BoiledTomato");
                        stove.CleanStove();
                    }
                }
            }

            if (triggerName == "Receivers")
            {
                if (heldItemName == "toastSlice")
                {
                    PlaceHeldItem();
                    breadOnPlate.SetActive(true);
                }

                if (heldItemName == "BoiledTomato")
                {
                    PlaceHeldItem();
                    TomatoOnPlate.SetActive(true);
                    
                }
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
