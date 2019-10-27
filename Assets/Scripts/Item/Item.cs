using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemKey key { get; private set; }
    public ItemNoisy noisy { get; private set; }
    public ItemGarbage garbage { get; private set; }

    private STATE state;

    enum STATE : int
    {
        KEY = 0,
        NOISY = 1,
        GARBAGE = 2,
    }

    public void Init (int n)
    {
        state = (STATE)Enum.ToObject (typeof (STATE), n);
        switch (state)
        {
            case STATE.KEY:
                key = this.gameObject.GetComponent<ItemKey> ();
                key.Init ();
                Debug.Log("Key Inited");
                break;

            case STATE.NOISY:
                noisy = this.gameObject.GetComponent<ItemNoisy> ();
                noisy.Init ();
                break;

            case STATE.GARBAGE:
                garbage = this.gameObject.GetComponent<ItemGarbage> ();
                garbage.Init ();
                break;

            default:
                Debug.Log ("何かがおかしいよ！ at Item Init()");
                break;
        }
    }

    public void ManagedUpdate ()
    {
        switch (state)
        {
            case STATE.KEY:
                key.ManagedUpdate ();
                break;

            case STATE.NOISY:
                noisy.ManagedUpdate ();
                break;

            case STATE.GARBAGE:
                garbage.ManagedUpdate ();
                break;

            default:
                Debug.Log ("何かがおかしいよ！ at Item ManagedUpdate()");
                break;
        }
    }

    

}