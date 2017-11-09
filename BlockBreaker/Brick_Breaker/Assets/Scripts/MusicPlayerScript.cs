using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;
    //static bool avaliableplayer = false;

	// Use this for initialization
	void Start () {

        //if (avaliableplayer = false)
        if(instance == null)
        {
            instance = this;
            //avaliableplayer = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            print("Duplicate MusicPlayer is self destructing; ");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
