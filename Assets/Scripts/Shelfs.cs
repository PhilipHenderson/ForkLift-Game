using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelfs : MonoBehaviour
{
    public bool blueShelf = false;
    public bool redShelf = false;
    public bool greenShelf = false;

    void OnCollisionEnter(Collision collision)
    {
        if (redShelf == true)
        {
            if (collision.gameObject.name == "Skid" && Skid.redSkid == true)
            {
                Debug.Log("Red Barrel Has Been Shelved!");
                Score.score += 2;
            }
            if (collision.gameObject.name == "Skid" && Skid.blueSkid == true)
            {
                Debug.Log("Blue Barrel Has Been Shelved, Wrong Shelf Tho!");
                Score.score += 1;
            }
            if (collision.gameObject.name == "Skid" && Skid.greenSkid == true)
            {
                Debug.Log("Green Barrel Has Been Shelved, Wrong Shelf Tho!");
                Score.score += 1;
            }
        }
        if (blueShelf == true)
        {
            if (collision.gameObject.name == "Skid" && Skid.redSkid == true)
            {
                Debug.Log("Red Barrel Has Been Shelved, Wrong Shelf Tho!");
                Score.score += 1;
            }
            if (collision.gameObject.name == "Skid" && Skid.blueSkid == true)
            {
                Debug.Log("Blue Barrel Has Been Shelved");
                Score.score += 2;
            }
            if (collision.gameObject.name == "Skid" && Skid.greenSkid == true)
            {
                Debug.Log("Green Barrel Has Been Shelved, Wrong Shelf Tho!");
                Score.score += 1;
            }
        }
        if (greenShelf == true)
        {
            if (collision.gameObject.name == "Skid" && Skid.redSkid == true)
            {
                Debug.Log("Red Barrel Has Been Shelved, Wrong Shelf Tho!");
                Score.score += 1;
            }
            if (collision.gameObject.name == "Skid" && Skid.blueSkid == true)
            {
                Debug.Log("Blue Barrel Has Been Shelved, Wrong Shelf Tho!");
                Score.score += 1;
            }
            if (collision.gameObject.name == "Skid" && Skid.greenSkid == true)
            {
                Debug.Log("Green Barrel Has Been Shelved");
                Score.score += 2;
            }
        }
    }
}