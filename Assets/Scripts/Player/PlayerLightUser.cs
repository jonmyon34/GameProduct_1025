using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightUser : MonoBehaviour
{
    public bool isLightOn { get; private set; }

    public void Init ()
    {
        isLightOn = false;
        Illuminate();
    }

    public void ManagedUpdate ()
    {
        if (Input.GetKeyDown (KeyCode.L))
        {
            LightOnOff ();
            Illuminate ();
        }
    }

    void LightOnOff ()
    {
        isLightOn = !isLightOn;
    }

    void Illuminate ()
    {
        if (isLightOn)
        {
            Light light = this.transform.Find ("Spot Light").gameObject.GetComponent<Light> ();
            if (light != null)
                light.enabled = isLightOn;
        }
        else if (!isLightOn)
        {
            Light light = this.transform.Find ("Spot Light").gameObject.GetComponent<Light> ();
            if (light != null)
                light.enabled = isLightOn;
        }
    }

}