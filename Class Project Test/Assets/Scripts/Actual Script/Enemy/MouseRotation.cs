using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    private Rigidbody myRB;
    public float moveSpeed;

    public Transform desiredWall;
    public Transform desiredWall2;

    public PlayerMoveScript thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        // Finds player each time and sets rigidbody.
        myRB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerMoveScript>();
    }

    private void FixedUpdate()
    {
        myRB.velocity = (new Vector3(0,0,-1) * moveSpeed);
    }


    // Update is called once per frame
    void Update()
    {
        if(myRB.transform.position.z >= 30)
        {
            myRB.velocity = (new Vector3(0, 0, 1) * moveSpeed);
        }

        if (myRB.transform.position.z == desiredWall2.position.x -5)
        {
            myRB.velocity = (new Vector3(0, 0, -1) * moveSpeed);
        }
        //transform.LookAt(thePlayer.transform.position);
    }
}
