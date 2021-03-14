using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody myRB;
    public float moveSpeed;

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
        myRB.velocity = (transform.forward * moveSpeed);
    }


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer.transform.position);
    }
}
