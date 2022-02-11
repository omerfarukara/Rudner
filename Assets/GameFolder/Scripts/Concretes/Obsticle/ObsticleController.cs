using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public class ObsticleController : MonoBehaviour
{

    public ElementColor elementColor;

    bool isCollect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constants.Tags.HANDLE))
        {
            gameObject.transform.SetParent(other.gameObject.transform);
            isCollect = true;
        }

        if (other.CompareTag(Constants.Tags.PLATFORM) && isCollect)
        {
           // Destroy(this.gameObject);
            isCollect = false;
            switch (elementColor)
            {
                case ElementColor.Blue:
                    GameManager.Instance.WheelController.ForwardMoveSpeed = 10;
                    break;
                case ElementColor.Red:
                    GameManager.Instance.WheelController.ForwardMoveSpeed = 3;
                    break;
                case ElementColor.Brown:     
                    transform.parent.gameObject.SetActive(false);
                    transform.parent.DetachChildren();
                    break;
                default:
                    break;
            }

        }

    }


    void Update()
    {

    }
}
