using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Robot;
    public Camera Main;
    public Camera Second;

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        //transform.position = target.position + offset;
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed);
        transform.position = smoothedPosition;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
      if(Robot.transform.position.x <= -159)
        {
            Main = Second;
        }
        */
    }
}
