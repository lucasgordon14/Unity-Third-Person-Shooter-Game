using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatIsInInventory : MonoBehaviour
{

    public InventoryControl invCon;
    public PlayerMoveScript playMove;


    public bool hasPrimary = true;
    public bool hasHundgun = false;
    public GameObject uzi;
    public GameObject handGun;
    public GunController gun;
    
    // public GunController gun;
    // public GunController uzi;
    // public GunController handGun;

    // Start is called before the first frame update
    void Start()
    {
      // gun = playMove.GetComponent<GunController>();
    }

    // Update is called once per frame
    void Update()
    {

        if(hasPrimary == true && invCon.slot1selected)
        {
            // gun = uzi;// Set uzi as weapon.
            uzi.SetActive(true);
            handGun.SetActive(false);
            playMove.gun = uzi.GetComponent<GunController>();
        }

        if (hasHundgun == true && invCon.slot2selected) // has weapon
        {
            uzi.SetActive(false);
            handGun.SetActive(true);
            playMove.gun = handGun.GetComponent<GunController>();


            //Debug.Log("stuff");
            //gun = handGun;
            //gun = invCon.;
            // set handgun as weapon.
        }
    }
}
