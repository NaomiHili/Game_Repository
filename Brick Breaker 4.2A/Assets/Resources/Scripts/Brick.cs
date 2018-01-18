using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    LevelManager levelManager = new LevelManager();

    public static int brickCount = 0;

    public int maxHits;

    int timesHit;

	// Use this for initialization
	void Start () {

        timesHit = 0;
        brickCount++;
        print(brickCount);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.tag == "Breakable")
        {
            timesHit++;
            //print(this.name + " : " + timesHit);

            if (timesHit >= maxHits)
            {                
                brickCount--;
                print(brickCount);

                CheckWin();

                Destroy(gameObject);
            }
        }
    } 

    public void CheckWin()
    {
        if (brickCount <= 0)
        {
            levelManager.LoadNextScene();
        }
    }

}
