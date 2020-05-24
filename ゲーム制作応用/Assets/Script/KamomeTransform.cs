using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamomeTransform : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.Translate(0.0f, 0.0f, 0.2f);
    }
}
