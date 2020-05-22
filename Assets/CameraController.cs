using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform followTransform;


    public Transform cameraTransform;


    public float normalSpeed;
    public float fastSpeed;

    public float movementSpeed;
    public float movementTime;

    public float rotationAmount;
    public Vector3 zoomAmount;

    public Quaternion newRotation;
    public Vector3 newPosition;
    public Vector3 newZoom;

    public Vector3 dragStartPosition;
    public Vector3 dragCurrentPosition;

    public Vector3 rotateStartPosition;
    public Vector3 rotateCurrentPosition;
    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
        newRotation = transform.rotation;
        Vector3 z = new Vector3(cameraTransform.localPosition.x, 50, cameraTransform.localPosition.z);
        //newZoom = cameraTransform.localPosition;
        newZoom = z;
        movementSpeed = 0.5f;
        normalSpeed = movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        if (followTransform != null)
        {
            transform.position = followTransform.position;
        }
        else {
            HandleMovementInput();

        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            followTransform = null;
        }

    }

   
     void HandleMovementInput()
    {
        movementSpeed = normalSpeed; 
        if (Input.GetKey(KeyCode.LeftShift)) {
            movementSpeed = fastSpeed;
        }



        //ROTATION
        if (Input.GetKey(KeyCode.Q)){
            newRotation *= Quaternion.Euler(Vector3.up * rotationAmount); 
        }
        if (Input.GetKey(KeyCode.E))
        {
            newRotation *= Quaternion.Euler(Vector3.up * -rotationAmount);
        }

        //zoom
        if (Input.GetKey(KeyCode.R)) {
            newZoom += zoomAmount;
        }
        if (Input.GetKey(KeyCode.F))
        {
            newZoom -= zoomAmount;
        }


        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow)) {
            newPosition += (transform.forward * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            newPosition += (transform.forward * -movementSpeed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition += (transform.right * -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition += (transform.right * movementSpeed);
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * movementSpeed);
        cameraTransform.localPosition = Vector3.Lerp(cameraTransform.localPosition, newZoom, Time.deltaTime * movementSpeed);

    }
}
