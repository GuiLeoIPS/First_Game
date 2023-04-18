using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Bumped into a wall");
        
        if(other.gameObject.tag == "Player"){
            if (GetComponent<MeshRenderer>().material.color == Color.red)
            {
                GetComponent<MeshRenderer>().material.color = Color.green;
                gameObject.tag = "Hit";
            }else
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
    }
}
