using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public float totalCountdownTime;

    public Text startCountdown;

    // Update is called once per frame
    void Update()
    {
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        totalCountdownTime -= Time.deltaTime;
        if (totalCountdownTime <= 0f)
        {
            SceneManager.LoadScene(1);
        }


    }
}
