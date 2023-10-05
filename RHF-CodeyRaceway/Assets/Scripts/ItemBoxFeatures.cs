using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFeatures : MonoBehaviour
{

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); 
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            Invoke("Reappear", 5f);
        }
    }

    private void Reappear()
    {
        gameObject.SetActive(true);
    }
}
