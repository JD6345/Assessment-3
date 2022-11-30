using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_pCam : MonoBehaviour
{
    public float mouseSensitivity = 400f; //Setting mouse sensitivity for camera movement
    public Transform playerBody; //Referencing player object
    float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Cursor is invisible while game is being played
    }

    public void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //^Inputs for looking around on both axis'
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //Minimum and maximum values for camera rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //Applying the rotation
        playerBody.Rotate(Vector3.up * mouseX); //Rotates the player object
    }

}
