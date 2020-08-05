using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCaam : MonoBehaviour
{
    public float Speed; 
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Speed * Time.deltaTime);
            
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right * Speed * Time.deltaTime);
        }
    }
}
