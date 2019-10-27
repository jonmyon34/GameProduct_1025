using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public ObstacleMover obstacleMover{get; private set;}

    public void Init()
    {
        obstacleMover = this.gameObject.GetComponent<ObstacleMover>();
        obstacleMover.Init();
    }

    public void ManagedUpdate()
    {
        obstacleMover.ManagedUpdate();

    }
}
