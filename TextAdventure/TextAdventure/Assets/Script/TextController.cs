using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //import this class for the unity text

public class TextController : MonoBehaviour {

    public Text myText; //import that class do this line works

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1,
                  corridor_0, stairs_0, floor, closet_door, corridor_1, stairs_1,
                   in_closet, corridor_2, stairs_2, corridor_3, courtyard};

    States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.cell;

    }

    // Update is called once per frame
    void Update()
    {
       if (myState == States.cell)                  { Cell(); }
       else if (myState == States.sheets_0)         { Sheets_0(); }
       else if (myState == States.mirror)           { Mirror(); }
       else if (myState == States.lock_0)           { Lock_0(); }
       else if (myState == States.cell_mirror)      { Cell_Mirror(); }
       else if (myState == States.sheets_1)         { Sheets_1(); }
       else if (myState == States.lock_1)           { Lock_1(); }
      // else if (myState == States.courtyard)          { Courtyard(); }
    }

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape. " +
                "\nThere are some dirty sheets on the bed, a mirror on the wall," +
                " and the door is locked from the outside.\n\n" +
                "Press S to view the Sheets, M to view the Mirror and L to " +
                "view the Lock.";
        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets_0; }

        else if (Input.GetKeyDown(KeyCode.M)) { myState = States.mirror; }

        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_0; }
    }

    void Sheets_0()
    {
        myText.text = "These are very dirty sheets! They really need to be changed!" +
            "\n\n Press on R to return to the cell!";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Mirror()
    {
        myText.text = "The dirty old mirror on the wall seeme loose!\n\n" +
                "Press T to take the mirror, Press R to return to the middle of the cell.";
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }

    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the combination is." +
                      "You wish you could somehow see where the dirty fingerprints were, maybe you could " +
                      " see the combination.\n\n" +
                      "Press R to return to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }      
    }

    void Cell_Mirror()
    {
        myText.text = "You are still in your cell and you STILL want to escape! There are" +
                       " some dirty sheets on the bed, a mark where the mirror was, and the door is STILL " + 
                       " there, firmly locked!\n\n" +
                       "Press S to view the sheet, L to view the lock.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.sheets_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = States.lock_1; }
    }

    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand won't make the sheets look any better!\n\n" + 
                       "Press R to return to the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, turn it round so you" +
                       " can see the lock. You can make out the fingerprints on the buttons and guess the" +
                       " combination. You press on the dirty buttons and hear a click.\n\n" +
                       "Press O to open the door, R to return to the cell.";

        if (Input.GetKeyDown(KeyCode.O)) { myState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell_mirror; }
    }

    void Corridor_0()
    {
        myText.text = "Well done you got out of the prison cell now you need toescape the prison. " +
                    "outside the prison cell there is a dirty floor, a closed closet door and a flight of stairs. " +
                    " Press  S to go up the stairs, F to look at the floor, and C to look at the closet door. ";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.stairs_0; }

        else if (Input.GetKeyDown(KeyCode.F)) { myState = States.floor; }

        else if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_door; }

    }

    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n" +
            "Press R to return to the corridor down the stairs";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }

    }

    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" +
            "To pick up the hair clip Press H or to go back to the corridor press R";

        if (Input.GetKeyDown(KeyCode.H)) { myState = States.corridor_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void Closet_Door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
        "Maybe you could find something around to help enourage it open?\n\n" +
        "Press C to look at the closet door, Press R to go back to the corridor";

        if (Input.GetKeyDown(KeyCode.C)) { myState = States.closet_door; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.corridor_0; }
    }

    void Corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?\n\n" + "To pick the lock Press P and to go up the stairs Press S";

        if (Input.GetKeyDown(KeyCode.P)) { myState = States.in_closet; }
        else if (Input.GetKeyDown(KeyCode.s)) { myState = States.stairs_1; }
    }



    //void Coutryard()
    //{
    //    myText.text = "You are finally FREE!\n\n" +
    //        "Press P to Play Again or Q to Quit";

    //    if (Input.GetKeyDown(KeyCode.P)) { myState = States.cell; }
    //    else if (Input.GetKeyDown(KeyCode.Q)) { UnityEditor.EditorApplication.isPlaying = false; }
    //}


}
