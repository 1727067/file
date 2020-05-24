using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour
{

    public GameObject mobs65;
    private Vector3[] enemyPos = new Vector3[10];

    // Use this for initialization
    void Start()
    {
        enemyPos[0] = new Vector3(0, 2.7f, 200);
        enemyPos[1] = new Vector3(0, 2.7f, 550);
        enemyPos[2] = new Vector3(0, 2.7f, 800);
        enemyPos[3] = new Vector3(0, 2.7f, 900);
        enemyPos[4] = new Vector3(0, 2.7f, 1050);
        enemyPos[5] = new Vector3(0, 2.7f, 1200);
        enemyPos[6] = new Vector3(0, 2.7f, 1300);
        enemyPos[7] = new Vector3(0, 2.7f, 1650);
        enemyPos[8] = new Vector3(0, 2.7f, 1750);
        enemyPos[9] = new Vector3(0, 2.7f, 1900);

        for (int i = 0; i < 9; i++)
        {
            GameObject enemy = Instantiate(mobs65) as GameObject;
            enemy.transform.position = enemyPos[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
