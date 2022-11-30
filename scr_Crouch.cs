using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Start of a crouching mechanic
public class scr_Crouch : MonoBehaviour
{
    [SerializeField] private float crouchHeight = 0.5f;
    [SerializeField] private float standingHeight = 2f;
    [SerializeField] private float crouchTime = 0.25f;
    [SerializeField] private Vector3 crouchingCenter = new Vector3(0,0.5f, 0);
    [SerializeField] private Vector3 standingCenter = new Vector3(0, 0, 0);
    private bool isCrouching;
    private bool duringCrouchAnimation;
    [SerializeField] private KeyCode crouchKey = KeyCode.LeftControl;


    void Start()
    {
        
    }


    void Update()
    {
     
    }
}
