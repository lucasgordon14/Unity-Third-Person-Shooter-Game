using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour
{
    public WhatIsInInventory inv;
    public GameObject handGunIcon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0); //rotates 50 degrees per second around y axis, rotates 10 degrees per second around x axis


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            inv.hasHundgun = true;
            handGunIcon.SetActive(true);
            // Set second slot icon as visible

        }

    }

}
