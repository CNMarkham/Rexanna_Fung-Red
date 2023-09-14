using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{

    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;

        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}
