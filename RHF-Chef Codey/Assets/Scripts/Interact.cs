using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public GameObject croissantPrefab;

    public GameObject CroissantOnPlate;
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
                else if (triggerName == "croissant (6)")
                {
                    PickupItem(croissantPrefab, "Croissant");
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
                else if (heldItemName == "Croissant")
                {
                    stove.ToastCroissant();
                    PlaceHeldItem();
                }
                else
                {
                    if (stove.cookedFood == "toast" && stove.isCooking == false)
                    {
                        PickupItem(breadPrefab, "toastSlice");
                        stove.CleanStove();
                    }

                    if (stove.cookedFood == "boiledTomato" && stove.isCooking == false)
                    {
                        PickupItem(boiledTomatoPrefab, "BoiledTomato");
                        stove.CleanStove();
                    }

                    if (stove.cookedFood == "toastedCroissant" && stove.isCooking == false)
                    {
                        PickupItem(croissantPrefab, "ToastedCroissant");
                        stove.CleanStove();
                    }

                }
            }

            if (triggerName == "Receivers")
            {
                if (heldItemName == "toastSlice")
                {
                    breadOnPlate.SetActive(true);
                    PlaceHeldItem();
                    
                }

                if (heldItemName == "BoiledTomato")
                {
                    TomatoOnPlate.SetActive(true);
                    PlaceHeldItem();
                    
                    
                }

                if (heldItemName == "ToastedCroissant")
                {
                    CroissantOnPlate.SetActive(true);
                    PlaceHeldItem();
                    

                }
            }

        }
    }

    private void PlaceHeldItem()
    {
        Destroy(heldItem);
        heldItemName = "";

        if(CroissantOnPlate.activeSelf && breadOnPlate.activeSelf && TomatoOnPlate.activeSelf)
        {
            SceneManager.LoadScene(2);
        }

    }

    private void PickupItem(GameObject prefab, string name)
    {
        heldItem = Instantiate(prefab, transform, false);
        heldItem.transform.localPosition = new Vector3(0, 2, 2);
        heldItemName = name;
    }


    private void OnTriggerStay(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }


}
