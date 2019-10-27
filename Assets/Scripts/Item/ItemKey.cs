using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemKey : MonoBehaviour
{
    public ItemEraser itemEraser{get; private set;}
    public ItemMover itemMover{get; private set;}

    public void Init()
    {
        itemEraser = this.gameObject.GetComponent<ItemEraser>();
        itemMover = this.gameObject.GetComponent<ItemMover>();
        itemEraser.Init();
        itemMover.Init();
    }

    public void ManagedUpdate()
    {
        itemEraser.ManagedUpdate();
        itemMover.ManagedUpdate();
    }
}
