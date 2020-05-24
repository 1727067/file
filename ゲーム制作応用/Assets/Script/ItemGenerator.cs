using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

    public GameObject itemramn;
    private Vector3[] coordinate = new Vector3[14];

    // Use this for initialization
    void Start()
    {
        coordinate[0] = new Vector3(0, 1.41f, 250);
        coordinate[1] = new Vector3(10, 1.41f, 350);
        coordinate[2] = new Vector3(-5, 1.41f, 450);
        coordinate[3] = new Vector3(-20, 1.41f, 600);
        coordinate[4] = new Vector3(-5, 1.41f, 700);
        coordinate[5] = new Vector3(0, 1.41f, 850);
        coordinate[6] = new Vector3(10, 1.41f, 1000);
        coordinate[7] = new Vector3(7.5f, 1.41f, 1150);
        coordinate[8] = new Vector3(15, 1.41f, 1250);
        coordinate[9] = new Vector3(0, 1.41f, 1350);
        coordinate[10] = new Vector3(0, 1.41f, 1500);
        coordinate[11] = new Vector3(0, 1.41f, 1600);
        coordinate[12] = new Vector3(2.5f, 1.41f, 1800);
        coordinate[13] = new Vector3(5, 1.41f, 1950);

        for (int i = 0; i < 14; i++)
        {
            GameObject x = Instantiate(itemramn) as GameObject;
            x.transform.position = coordinate[i];
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
