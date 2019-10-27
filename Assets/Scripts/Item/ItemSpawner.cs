using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject keyPrefab { get; private set; }
    public GameObject noisyPrefab { get; private set; }
    public GameObject garbagePrefab { get; private set; }

    private Vector3 pos;
    private Vector3 rota;

    const float POS_RANDVAL_MIN = -5.0f;
    const float POS_RANDVAL_MAX = 5.0f;

    const float POS_RANDVAL_ABS_MIN = 4.0f;
    const float POS_RANDVAL_ABS_MAX = 10.0f;

    enum STATE : int
    {
        KEY = 0,
        NOISY = 1,
        GARBAGE = 2,
    }

    public void Init ()
    {
        keyPrefab = (GameObject)Resources.Load ("Prefabs/Key");
        noisyPrefab = (GameObject)Resources.Load ("Prefabs/Noisy");
        garbagePrefab = (GameObject)Resources.Load ("Prefabs/Garbage");
    }

    public GameObject ItemSpawn (int n)
    {
        RandomPos ();
        RandomRota ();

        STATE state = (STATE)Enum.ToObject (typeof (STATE), n);

        switch (state)
        {
            case STATE.KEY:
                Debug.Log ("Key Spawend");
                return Instantiate (keyPrefab, pos, Quaternion.Euler (rota));
            case STATE.NOISY:
                Debug.Log ("Noisy Spawend");
                return Instantiate (noisyPrefab, pos, Quaternion.Euler (rota));
            case STATE.GARBAGE:
                Debug.Log ("Garbage Spawend");
                return Instantiate (garbagePrefab, pos, Quaternion.Euler (rota));
            default:
                break;
        }

        Debug.Log ("何かがおかしいよ！ at ItemSpawner ItemSpawn(int n)");
        return null;
    }

    public Vector3 RandomPos ()
    {
        while (true)
        {
            pos.x = UnityEngine.Random.Range (-POS_RANDVAL_ABS_MAX, POS_RANDVAL_ABS_MAX);
            pos.z = UnityEngine.Random.Range (-POS_RANDVAL_ABS_MAX, POS_RANDVAL_ABS_MAX);

            float len = Vector3.Magnitude (pos);
            if (len > POS_RANDVAL_ABS_MIN)break;
        }
        return pos;
    }

    public Vector3 RandomRota ()
    {
        rota.y = UnityEngine.Random.Range (-180.0f, 180.0f);

        return rota;
    }

}