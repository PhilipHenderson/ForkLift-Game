using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skid : MonoBehaviour
{
    public static bool blueSkid = false;
    public static bool redSkid = false;
    public static bool greenSkid = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BlueBarrel")
        {
            Debug.Log("Touching Blue Barrel");
            blueSkid = true;
            if (RedShelfPS.pointScored == true)
            {
                Score.score += 1;
            }
        }
        if (collision.gameObject.name == "RedBarrel")
        {
            Debug.Log("Touching Red Barrel");
            redSkid = true;
            if (RedShelfPS.pointScored == true)
            {
                Score.score += 1;
            }
        }
        if (collision.gameObject.name == "GreenBarrel")
        {
            Debug.Log("Touching Green Barrel");
            greenSkid = true;
            if (RedShelfPS.pointScored == true)
            {
                Score.score += 1;
            }
        }
    }
}
