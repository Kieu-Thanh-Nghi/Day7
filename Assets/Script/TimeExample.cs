using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeExample : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time since start: " + Time.time);
        Debug.Log("Time between frames: " + Time.deltaTime);
    }
}
