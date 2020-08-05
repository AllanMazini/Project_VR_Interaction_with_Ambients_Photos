using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ControllerCaam : MonoBehaviour
{
    public GameObject _buttonRight;
    public GameObject _buttonLeght;
    Button _component, _component2;
    public float Speed; 
   
    void Start()
    {
        _component = _buttonRight.GetComponent<Button>();
        _component2 = _buttonLeght.GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Rotate(0, Speed * _component.input * Time.deltaTime, 0 );
        transform.Rotate(0, -Speed * _component2.input * Time.deltaTime, 0 );

    }

 
}
