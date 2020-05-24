using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamomeGenerator : MonoBehaviour {

    public GameObject kamome;
    private GameObject mainMan;

    public float currentTime;
    bool kamomeFlag = false;

    int rand;

    void Start()
    {
        mainMan = GameObject.Find("mainman2_neo");
    }

    void Update () {
        currentTime += Time.deltaTime;

        if(currentTime >= 10)
        {
            kamomeFlag = true;
            currentTime = 0;
        }

        if (kamomeFlag)
        {
            rand = Random.Range(0, 2);
            GameObject x = Instantiate(kamome) as GameObject;

            if (rand == 0)
            {
                x.transform.position = new Vector3(-50, 20, mainMan.transform.position.z + 200);
                x.transform.Rotate(new Vector3(0, 90, 0));
                kamomeFlag = false;
            }
            else
            {
                x.transform.position = new Vector3(50, 20, mainMan.transform.position.z + 200);
                x.transform.Rotate(new Vector3(0, -90, 0));
                kamomeFlag = false;
            }

        }
        
    }

}
