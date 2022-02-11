using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [Header("| Wheel Movement Variables |")]
    [SerializeField] float forwardMoveSpeed;

    public float ForwardMoveSpeed
    {
        get
        {
            return forwardMoveSpeed;
        }
        set
        {
            forwardMoveSpeed = value;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        GameManager.Instance.WheelMovement.WheelRotate(this.transform);
        GameManager.Instance.WheelMovement.WheelForwardMove(this.transform, forwardMoveSpeed);
    }
}
