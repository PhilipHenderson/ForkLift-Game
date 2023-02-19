using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    void Start()
    {
        print("Score: " + score);
    }
    void Update()
    {
        scoreText.text = score.ToString("0");
    }
}
