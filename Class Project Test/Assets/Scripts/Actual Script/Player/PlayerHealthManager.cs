﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{ 
    public int startingHealth;
    public int currentHealth;

   // public float flashLength;
    //private float flashCounter;

    //private Renderer rend;
    //private Color storedColor;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
       // rend = GetComponent<Renderer>();
        //storedColor = rend.material.GetColor("_Color");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

    }

    public void hurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        //flashCounter = flashLength;
        //rend.material.SetColor("_Color", Color.red);
    }

}
