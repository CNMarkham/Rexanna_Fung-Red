using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stove : MonoBehaviour
{

    public GameObject toast;

    public GameObject boiledTomatoes;


    public string triggername = "";

    public string cookedFood = "";

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
        boiledTomatoes.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToastBread()
    {
        toast.SetActive(true);
        cookedFood = "toast";
    }

    public void BoilTomatoes()
    {
        boiledTomatoes.SetActive(true);
        cookedFood = "boiledTomato";
    }

    public void CleanStove()
    {
        toast.SetActive(false);
        boiledTomatoes.SetActive(false);
        cookedFood = "";
    }

   
}
