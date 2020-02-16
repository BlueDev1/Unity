using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyUp;

    [SerializeField]
    KeyCode keyDown;
    
        
  


    void FixedUpdate()
    {
        if (Input.GetKey(keyUp))
            GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(keyDown))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}

