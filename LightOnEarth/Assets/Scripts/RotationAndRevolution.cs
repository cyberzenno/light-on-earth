using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAndRevolution : MonoBehaviour
{
    void Update()
    {
        var daysPerYear = 10;
        var secondsPerYear = 10;
 
        // Earth revolution
        transform.RotateAround(Vector3.zero, Vector3.up, SecondsPerRevolution(secondsPerYear));

        // Earth rotation
        transform.Rotate(Vector3.up, RotationsPerSecond(daysPerYear / secondsPerYear));
    }

    float RotationsPerSecond(float rotations)
    {
        return -360 * rotations * Time.deltaTime;
    }

    float SecondsPerRevolution(int seconds)
    {
        return (-360 / seconds) * Time.deltaTime;
    }
}
