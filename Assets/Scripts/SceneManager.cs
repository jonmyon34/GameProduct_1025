using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public PlayerManager plManager;
    public ItemManager itemManager;

    void Start()
    {
        plManager.Init();
        itemManager.Init();
    }

    void Update()
    {
        plManager.ManagedUpdate();
        itemManager.ManagedUpdate();   
    }
}
