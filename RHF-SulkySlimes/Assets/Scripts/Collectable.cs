using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{

    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = -1f;

    [Header("Scene to Load")]
    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        endingPosition = startingPosition + new Vector3(distanceToMove, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startingPosition.x)
        {
            direction = 1f;
        }

        if(transform.position.x > endingPosition.x)
        {
            direction = -1f;
        }

        transform.position += new Vector3(speed * direction * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Invoke("LoadNextScene", 2f);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
