using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel_1 : MonoBehaviour {
    float y = 0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

   
        if (Input.GetKey(KeyCode.UpArrow))
        { y += .2f; }
        if (Input.GetKey(KeyCode.DownArrow))
        { y -= .2f; }

        this.transform.position = new Vector3(transform.position.x,y, transform.position.z);

       
    }
}
