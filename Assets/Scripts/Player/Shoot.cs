using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Player
{

    public Transform shot_point;
    public GameObject bullet;
    public GameObject ability_PB;


    private void Update()
    {
        commonAtack();
    }

    public void commonAtack()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("dispare");
            Instantiate(bullet, shot_point);
        }
    }
}
