using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Throwable : MonoBehaviour
{

    public GameObject objectThrown;

    public Vector3 offset;

    public int throwablecounter;

    public Text collectableCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && throwablecounter > 0)
        {
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;

            Instantiate(objectThrown, throwablePosition, transform.rotation);
            throwablecounter -= 1;
            collectableCounter.text = throwablecounter.ToString();
            //Change the counter
            //Go to text for score/counter stuff thingy thing
            //Then change it using code
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Collectable")
        {
            throwablecounter += 1;
            collectableCounter.text = throwablecounter.ToString();
            Destroy(collision.gameObject);


        }
        
    }

 
}