using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEraser : MonoBehaviour,Grabable
{
    public void Init()
    {

    }

    public void ManagedUpdate()
    {
        
    }

    public void Grabable()
    {
        Destroy(this.gameObject);
    }
}
