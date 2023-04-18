using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float rotationx = 0;
    [SerializeField] float rotationy = 0;
    [SerializeField] float rotationz = 0;
    [SerializeField] float rotationspeed;
    [SerializeField] bool reverse = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationy = rotationy * Time.deltaTime * rotationspeed;
        if(reverse){
            transform.Rotate(rotationx,-rotationy,rotationz);
            rotationy++;
        }else{
            transform.Rotate(rotationx,rotationy,rotationz);
            rotationy++;
        }
    }
}
