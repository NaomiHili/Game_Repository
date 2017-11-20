using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    int timesHit;

	// Use this for initialization
	void Start () {

        timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);
    }
}
