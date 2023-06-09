using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] int delay;
    [SerializeField] GameObject cube; 
    float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > delay){
            Instantiate(cube, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
