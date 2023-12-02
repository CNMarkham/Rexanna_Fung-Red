using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private Quaternion lastLook;
    public float rotationSpeed = 45f;
    public float speed;
    public Transform camTransform;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        anim = GetComponent<Animator>();
        lastLook = transform.rotation;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Vector3 movementVector = new Vector3(horizontal, 0, vertical).normalized;

        Vector3 movementVector = camTransform.forward * vertical;// + camTransform.right * horizontal;
        movementVector.y = 0;
        movementVector.Normalize();

        //transform.rotation = lastLook;
        transform.Rotate(Vector3.up, horizontal * Time.deltaTime * rotationSpeed);

        //Vector3 movement = new Vector3(horizontal, 0, 0) * speed / 100;
        rb.MovePosition(transform.position + movementVector * speed);

        anim.SetFloat("horizontalVector", movementVector.magnitude);
        anim.SetFloat("verticalVector", 0);
    }

}
