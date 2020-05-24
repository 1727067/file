using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrentPlace : MonoBehaviour
{

    private GameObject obj;
    private float allowPos_x = 100f;
    private float allowAddPos_y = 60;

    // Use this for initialization
    void Start()
    {
        obj = GameObject.Find("mainman2_neo");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(allowPos_x, obj.transform.position.z / 4f + allowAddPos_y, 0);
    }
}
