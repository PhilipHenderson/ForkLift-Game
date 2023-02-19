using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float startTime = 0f;
    private float currTime;
    public Text timer;

    void Update()
    {
        currTime = startTime += Time.deltaTime;
        timer.text = currTime.ToString("0");
    }


}
