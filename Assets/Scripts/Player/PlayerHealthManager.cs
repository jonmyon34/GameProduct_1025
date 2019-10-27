using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    int HP;
    const int DEFAULT_HP = 3;
    public bool existFlg{get;private set;}

    public void Init()
    {
        HP = DEFAULT_HP;
        existFlg = true;
    }

    public void ManagedUpdate()
    {

    }

    void ApplyDamage()
    {
        HP--;
    }
}
