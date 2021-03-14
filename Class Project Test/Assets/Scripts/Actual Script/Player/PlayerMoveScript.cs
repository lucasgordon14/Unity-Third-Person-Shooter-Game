using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody myRigidBody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public GameObject PauseMenu;

    public Camera mainCamera;

    public GunController gun;

    public int index;

    public bool useController;

    // Start is called before the first frame update
    void Start()
    {
       
        myRigidBody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        // Rotate with mouse
        if (!useController)
        {
            Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
            float rayLength;

            if (groundPlane.Raycast(cameraRay, out rayLength))
            {
                Vector3 pointToLook = cameraRay.GetPoint(rayLength);
                Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);

                transform.LookAt(pointToLook);
            }

            if (Input.GetMouseButtonDown(0))
            {
                gun.isFiring = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                gun.isFiring = false;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseMenu.SetActive(true);
            }
        }
            //Rotate with controller
            if (useController)
            {
                Vector3 playerDirection = Vector3.right * Input.GetAxisRaw("RHorizontal") + Vector3.forward * Input.GetAxisRaw("RVertical");
                // Test
                //Vector3 playerDirection1 = Vector3.right * Input.GetAxisRaw("RightJoystickHorizontal") + Vector3.forward * Input.GetAxisRaw("RightJoystickVertical");

                if (playerDirection.sqrMagnitude > 0.0f)
                {
                    transform.rotation = Quaternion.LookRotation(playerDirection, Vector3.up);
                    // Test
                    //transform.rotation = Quaternion.LookRotation(playerDirection1, Vector3.up);
                }

                if (Input.GetKeyDown(KeyCode.Joystick1Button7))
                {
                    gun.isFiring = true;
                }

                if (Input.GetKeyUp(KeyCode.Joystick1Button7))
                {
                    gun.isFiring = false;
                }
            }
        }

        void FixedUpdate()
        {
            myRigidBody.velocity = moveVelocity;
        }
    
}
