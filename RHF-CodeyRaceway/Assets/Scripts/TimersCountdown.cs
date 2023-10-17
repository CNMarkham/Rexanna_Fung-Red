using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{

    public CodeyMove codey; 
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    // Update is called once per frame
    void Update()
    {

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        if (totalCountdownTime > 0f)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = totalCountdownTime.ToString();
            codey.Speed = 0f;
        }
        if (totalCountdownTime <= 0f)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = totalLapTime.ToString();
            codey.Speed = 1500;
        }
        if (totalLapTime < 0f)
        {
            Debug.Log("Time's up!");
            SceneManager.LoadScene(1);
        }
    }
}
