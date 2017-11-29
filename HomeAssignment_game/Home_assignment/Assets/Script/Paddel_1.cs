using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel_1 : MonoBehaviour {
    float x = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

   
        if (Input.GetKey(KeyCode.RightArrow))
        { x += .2f; }
        if (Input.GetKey(KeyCode.LeftArrow))
        { x -= .2f; }

        this.transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
