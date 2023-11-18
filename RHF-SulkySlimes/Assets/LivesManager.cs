using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{

    public int lives;

    public GameObject[] hearts;


    // Start is called before the first frame update
    public void RemoveLife()
    {
        lives -= 1;
        print("You lost a life! Lives: " + lives);
        hearts[lives].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
