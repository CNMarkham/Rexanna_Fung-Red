using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseManager : MonoBehaviour
{

    [Header("MouseInfo")]
    public Vector3 clickStartLocation;

    [Header("Pyshics")]
    public Vector3 launchVector;
    public float launchForce;

    public Transform slimeTransform;
    public Rigidbody slimeRigid;

   public Vector3 BobXIX;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f);
            slimeTransform.position = BobXIX - launchVector / 400;
            launchVector.Normalize();
        }

        if(Input.GetMouseButtonUp(0))
        {
            print("Release!");
            slimeRigid.isKinematic = false;
            slimeRigid.AddForce(launchVector * launchForce, ForceMode.Impulse);

        }

        if(Input.GetKeyDown("space"))
        {
            slimeTransform.position = (BobXIX);
            slimeRigid.isKinematic = true;
        }

    }
}
