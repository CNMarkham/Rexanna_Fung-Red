using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{

    public GameObject toast;

    public GameObject boiledTomatoes;

    public GameObject toastedCroissant;


    public string triggername = "";

    public string cookedFood = "";

    public ParticleSystem smoke;
    public ParticleSystem complete;

    public bool isCooking = false;

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
        boiledTomatoes.SetActive(false);
        toastedCroissant.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToastBread()
    {
        isCooking = true;
        smoke.Play();
        toast.SetActive(true);
        cookedFood = "toast";
        Invoke("CompleteCooking", 6f);
    }

    public void BoilTomatoes()
    {
        isCooking = true;
        smoke.Play();
        boiledTomatoes.SetActive(true);
        cookedFood = "boiledTomato";
        Invoke("CompleteCooking", 5f);
    }

    public void ToastCroissant()
    {
        isCooking = true;
        smoke.Play();
        toastedCroissant.SetActive(true);
        cookedFood = "toastedCroissant";
        Invoke("CompleteCooking", 7f);
    }

    public void CleanStove()
    {
        toast.SetActive(false);
        boiledTomatoes.SetActive(false);
        toastedCroissant.SetActive(false);
        cookedFood = "";
        complete.Stop();
    }

    public void CompleteCooking()
    {
        isCooking = false;
        smoke.Stop();
        complete.Play();
    }
}
