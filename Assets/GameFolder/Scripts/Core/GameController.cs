using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.WheelMovement = new WheelMovement();
        GameManager.Instance.WheelController = GameObject.FindGameObjectWithTag(Constants.Tags.WHEEL).GetComponent<WheelController>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
