using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;
    public GameObject Restart;
    public GameObject Back;

    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        Restart.SetActive(false);
        Back.SetActive(false);
        timerBar = GetComponent<Image> ();
        timeLeft = maxTime;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
            Restart.SetActive(true);
            Back.SetActive(true);
        }
        
    }
}
