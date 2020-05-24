using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetContoller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            CountTime.Instance.currentTime += 3.0f;
            Destroy(this.gameObject);
        }
    }
}
