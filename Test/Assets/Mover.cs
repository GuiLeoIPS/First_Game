using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        printinstructions();
    }

    // Update is called once per frame
    void Update()
    {
        moveplyaer();

    }


    void printinstructions(){
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with the WASD keys");
        Debug.Log("Dont hit the walls");
    }

    void moveplyaer(){
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue,0,zvalue);
    }
    
}
