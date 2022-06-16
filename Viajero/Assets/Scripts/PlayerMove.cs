using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerMove : MonoBehaviour
{
    public FixedJoystick joystick;
    public JoyButton joybutton;
    public FixedTouchField touchfield;

    // protected bool jump;

    void Start ()
    {

    }

    void Update () 
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();

        fps.RunAxis = joystick.Direction;
        fps.JumpAxis = joybutton.Pressed;
        fps.mouseLook.LookAxis = touchfield.TouchDist;
    }


    // void Start()
    // {
    //     joystick = FindObjectOfType<Joystick>();
    //     joybutton = FindObjectOfType<JoyButton>();
    // }

    // void Update()
    // {
    //     //public Vector3(float x, float y, float z);    
    //     var rigidbody = GetComponent<Rigidbody>();
    //     rigidbody.velocity = new Vector3(joystick.Vertical * 100f + Input.GetAxis("Vertical") * 100f,
    //                                     rigidbody.velocity.y,
    //                                     joystick.Horizontal * -100f + Input.GetAxis("Horizontal") * -100f);
    //     if(!jump && joybutton.Pressed)
    //     {
    //         jump = true;
    //         rigidbody.velocity += Vector3.up * 100f;
    //     }

    //     if(jump && !joybutton.Pressed)
    //     {
    //         jump = false;
    //     }
    // }
}
