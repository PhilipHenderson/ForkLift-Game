using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forks : MonoBehaviour
{    
    public float liftSpeed;
    //public float maxUp = 5;
    //public float maxDown = 0;

    public float extentionSpeed = 2;
    //public float maxOut = 3;
    //public float maxIn = 0;

    //void Start()
   // {
        //transform.eulerAngl
    //}
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        Lift();
        Extention();
    }
    void Lift()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * liftSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * -liftSpeed * Time.deltaTime);
        }
    }

    void Extention()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * extentionSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector3.forward * -extentionSpeed * Time.deltaTime);
        }
    }
}
