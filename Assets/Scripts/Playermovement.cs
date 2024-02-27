using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Character_Controller controller;

    public float horizontalmove= 0f;
    public float runspeed = 40f;
    bool jump = false;

    void Start()
    {
        
    }

    
    void Update()
    {
       horizontalmove = Input.GetAxisRaw("Horizontal")*runspeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }
    private void FixedUpdate()
    {
        controller.Move(horizontalmove*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
