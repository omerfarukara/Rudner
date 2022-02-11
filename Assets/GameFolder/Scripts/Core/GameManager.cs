using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    WheelMovement wheelMovement;
    WheelController wheelController;

    public WheelMovement WheelMovement
    {
        get
        {
            return wheelMovement;
        }
        set
        {
            wheelMovement = value;
        }
    }

    public WheelController WheelController
    {
        get
        {
            return wheelController;
        }
        set
        {
            wheelController = value;
        }
    }


    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {

    }
}
