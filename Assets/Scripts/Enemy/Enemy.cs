using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour , Damagable
{
    public float Enlife;
    public float Enspeed;

    public virtual void TakeDmg(int dmg)
    {
        Enlife -= dmg;

        if (Enlife <= 0)
            Destroy(gameObject);

    }
}
