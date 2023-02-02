using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{   
    private float _XInput;
    public float XInput
    {
        get => _XInput;
        set
        {

        }
    }

    private float _YInput;
    public float YInput => _YInput;

    
    private bool _Fire1;
    public bool Fire1 => _Fire1;
    
    
    void Update()
    {        
        _XInput = Input.GetAxis("Mouse X");
        _YInput = Input.GetAxis("Mouse Y");
        _Fire1 = Input.GetButtonDown("Fire1");

    }
}
