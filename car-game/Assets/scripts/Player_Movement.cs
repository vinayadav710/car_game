using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public GameObject PLayer; 
    public float ForwardSpeed = 0.5f;
    public float Rotation = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            PLayer.transform.Translate(ForwardSpeed *Time.deltaTime,0,0);
            }
        if(Input.GetKey("a"))
        {
            PLayer.transform.Rotate(0,-Rotation*Time.deltaTime,0);
            }
            if(Input.GetKey("d"))
        {
            PLayer.transform.Rotate(0,Rotation*Time.deltaTime,0);
            }
        if(Input.GetKey("s"))
        {
            PLayer.transform.Translate(-ForwardSpeed *Time.deltaTime,0,0);
            }
        
        
    }
}
