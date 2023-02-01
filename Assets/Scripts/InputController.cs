using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{   
    public float _xInput;
    public float _yInput;
    
    void Update()
    {        
        _xInput = Input.GetAxis("Mouse X");        
        _yInput = Input.GetAxis("Mouse Y");
    }
}
