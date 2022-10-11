using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_player : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame updateS
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        //transform.rotation = player.rotation + offset;
    }
}
