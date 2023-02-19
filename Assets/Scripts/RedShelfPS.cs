using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShelfPS : MonoBehaviour
{
    public bool blueShelf;
    public bool redShelf;
    public bool greenShelf;
    public static bool pointScored;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Skid" && Skid.redSkid == true && pointScored == false)
        {
            Debug.Log("Red Barrel Has Been Shelved!");

            pointScored = true;
        }
        if (collision.gameObject.name == "Skid" && Skid.blueSkid == true && pointScored == false)
        {
            Debug.Log("Blue Barrel Has Been Shelved, Wrong Shelf Tho!");

            pointScored = true;
        }
        if (collision.gameObject.name == "Skid" && Skid.greenSkid == true && pointScored == false)
        {
            Debug.Log("Green Barrel Has Been Shelved, Wrong Shelf Tho!");

            pointScored = true;
        }
    }
}