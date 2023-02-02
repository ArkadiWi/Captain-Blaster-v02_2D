using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{    
    private float _XInput;
    public float XInput
    {
        get => _XInput;        
    }

    private float _YInput;
    public float YInput => _YInput;

    
    private bool _Fire1;
    public bool Fire1 => _Fire1;

    private bool _Fire2;
    public bool Fire2 => _Fire2;


    void Update()
    {        
        _XInput = Input.GetAxis("Mouse X");
        _YInput = Input.GetAxis("Mouse Y");
        _Fire1 = Input.GetButtonDown("Fire1");
        _Fire2 = Input.GetButtonDown("Fire2");
    }
}
