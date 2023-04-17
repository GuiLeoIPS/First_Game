using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Bumped into a wall");
        if (GetComponent<MeshRenderer>().material.color == Color.red)
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
}
