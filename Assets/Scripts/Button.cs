using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
     public float input;
     public float sensitility;
     bool pressicion;
    
public void OnPointerDown(PointerEventData eventData){
    pressicion = true;
}
public void OnPointerUp(PointerEventData eventData){
    pressicion = false;
}

    void Update()
    {
        if (pressicion)
        {
            input += Time.deltaTime * sensitility;
        }else{
            input -= Time.deltaTime * sensitility;
        }
        input = Mathf.Clamp(input, 0 , 1);
    }
}
