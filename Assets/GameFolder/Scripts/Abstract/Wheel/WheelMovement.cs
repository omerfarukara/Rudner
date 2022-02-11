using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMovement
{
    public void WheelRotate(Transform wheelTransform)
    {
        wheelTransform.Rotate(0, 0, 1);
    }

    public void WheelForwardMove(Transform wheelTransform, float forwardMovespeed)
    {
        wheelTransform.localPosition += Vector3.forward * forwardMovespeed * Time.deltaTime;
    }
}