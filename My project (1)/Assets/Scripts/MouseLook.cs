using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Mouse Sensitivity
    [SerializeField] private float sensitivity;

    //Vertical Clamp
    [SerializeField] private float clamp;

    //Camera
    [SerializeField] private GameObject cam;

    //Player Obj
    [SerializeField] private GameObject player;

    //X Rotation
    private float xPos;

    //Y Rotation
    private float yPos;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        //Assign X and Y to a Vector3
        Vector3 rot = transform.localRotation.eulerAngles;

        //Set X and Y to equal Camera rotation
        xPos = rot.x;
        yPos = rot.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Get mouse position movement and assign to the floats
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //Modify the floats by the Mouse X and Y multiplied by Sensitivity and Delta Time
        xPos += mouseX * sensitivity * Time.deltaTime;
        yPos += mouseY * sensitivity * Time.deltaTime;

        //Apply Clamps
        yPos = Mathf.Clamp(yPos, -clamp, clamp);

        //Create a local Quaternion 
        Quaternion localRot = Quaternion.Euler(-yPos, xPos, 0f);
        Quaternion bodyRot = Quaternion.Euler(0f, xPos, 0f);

        //Update the rotation
        transform.rotation = localRot;
        player.transform.rotation = bodyRot;
    }
}
