using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Finish" && other.gameObject.tag != "Respawn"){
            hits++;
            Debug.Log("You bumped an obstacle! Watch out!");
        }

        if(other.gameObject.tag == "Finish"){
            Debug.Log("You reached the end!!");
            Debug.Log("Obstacles hit: " + hits);
            Debug.Log("You cleared the level in " + Time.time + " seconds!!");
        }
    }
}
