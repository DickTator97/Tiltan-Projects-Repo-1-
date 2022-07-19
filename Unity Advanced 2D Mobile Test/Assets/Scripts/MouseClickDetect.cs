using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickDetect : MonoBehaviour
{
   public Vector3 Offset;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("On Mouse Down:");
        //Calculate the offset between mouse click and transform
        Vector3 MouseDown_Position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        MouseDown_Position.z = transform.position.z;
        Offset = MouseDown_Position - transform.position;
   
    }

    private void OnMouseDrag()
    {
        
        Vector3 MousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = transform.position.z;
        transform.position = MousePosition-Offset;
    }

    private void OnMouseUp()
    {
       
        Debug.Log("On Mouse Up:");
    
    }
}
