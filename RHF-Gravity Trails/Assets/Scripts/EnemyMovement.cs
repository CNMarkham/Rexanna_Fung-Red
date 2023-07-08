using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float xForce;

    public float yForce;

    public float xDirection;

    private Rigidbody2D enemyRidgidbody;

    public int maximumPosition;

    public int minimumPosition;

    public Teleport teleport;

    // Start is called before the first frame update
    void Start()
    {
        enemyRidgidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRidgidbody.AddForce(jumpForce);
        }

        if (collision.gameObject.tag == "ThrowingObject")
        {
            teleport.enemyCount -= 1;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumPosition)
        {
            xDirection = 1;
            enemyRidgidbody.AddForce(Vector2.right * xForce);
        }

        if (transform.position.x >= maximumPosition)
        {
            xDirection = -1;
            enemyRidgidbody.AddForce(Vector2.left * xForce);
        }

    }

    public bool CheckGround()
    {
       return true;
    }




}
