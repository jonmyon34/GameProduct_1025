using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightUser : MonoBehaviour
{
    private bool isLightOn;

    public void Init()
    {
        isLightOn = false;
    }

    public void ManagedUpdate()
    {
        if(false)
        {
            LightOnOff();
        }
    }

    void LightOnOff()
    {
        isLightOn = !isLightOn;
    }

}
