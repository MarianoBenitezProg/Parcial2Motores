using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Values")]
    private int _PlayerLife = 200;
    public float _movSpeed = 1;
    [SerializeField] public Rigidbody2D _PlayerRb;



    void Update()
    {
        if (_PlayerLife <= 0)
        {
            Destroy(gameObject);
        }

    }
    public virtual void move()
    {
        Debug.Log("move esta funcionando");
    }

    public virtual void shoot()
    {
        Debug.Log("shoot esta funcionando");
    }
}
