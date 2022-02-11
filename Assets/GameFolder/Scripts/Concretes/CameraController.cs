using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 offset;

    void Start()
    {
        offset = transform.position - GameManager.Instance.WheelController.transform.position;
    }

    void LateUpdate()
    {
        transform.position = GameManager.Instance.WheelController.transform.position + offset;
    }
}
