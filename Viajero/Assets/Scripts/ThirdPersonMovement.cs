using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    //travel in camera direction
    public Transform cam;

    public float speed = 6f;
    //smoother turnAnimation
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        //if two keys are held down together, move isn't faster
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
    
        if(direction.magnitude >= 0.1f)
        {
            //take the direction magnitude and calculate how much to rotate by y-axis
            //Mathf.Rad2Deg to convert to degree
            float targetAngle = (Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg) + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            //Quaternion Euler allows to input 3 numbers (rotation around x,y,z)
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            //make sure that camera angle and player movement direction are the same
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            //make it frame rate independent
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }
}
