using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    public PlayerMoveScript thePlayer;
    public InventoryControl inv;
    public GameObject square;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;

    public Transform trans;



    public bool slot1selected = true;
    public bool slot2selected = false;
    public bool slot3selected = false;
    public bool slot4selected = false;
    public bool slot5selected = false;

    // Location of selected square.
    /*
    private float slot1x = 32.5f;
    private float slot1y = -36.0f;

    public int slot2x = 85;
    public int slot2y = -36;

    public int slot3x = 137;
    public int slot3y = -36;

    public int slot4x = 190;
    public int slot4y = -36;

    public int slot5x = 242;
    public int slot5y = -36;
    */

    private Vector3 square1loc = new Vector3(32.5f, 367f, 0f);
    private Vector3 square2loc = new Vector3(85.0f, 367f, 0f);
    private Vector3 square3loc = new Vector3(137f, 367f, 0f);
    private Vector3 square4loc = new Vector3(190f, 367f, 0f);
    private Vector3 square5loc = new Vector3(242f, 367f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        // Test
        slot1selected = true;
        slot2selected = false;
        slot3selected = false;
        slot4selected = false;
        slot5selected = false;

        square.transform.position = slot1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        // Location of selected square.
        float slot1x = 32.0f;
        float slot1y = -36.0f;

        float slot2x = 85.0f;
        float slot2y = -36.0f;

        float slot3x = 137f;
        float slot3y = -36f;

        float slot4x = 190f;
        float slot4y = -36f;

        float slot5x = 242f;
        float slot5y = -36f;

        Vector3 slot1Pos = new Vector3(slot1x, slot1y, 0f);
        Vector3 slot2Pos = new Vector3(slot2x, slot2y, 0f);
        */

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            slot1selected = true;
            slot2selected = false;
            slot3selected = false;
            slot4selected = false;
            slot5selected = false;

            square.transform.position = slot1.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            slot1selected = false;
            slot2selected = true;
            slot3selected = false;
            slot4selected = false;
            slot5selected = false;

            square.transform.position = slot2.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            slot1selected = false;
            slot2selected = false;
            slot3selected = true;
            slot4selected = false;
            slot5selected = false;

            square.transform.position = slot3.transform.position;
        }


        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            slot1selected = false;
            slot2selected = false;
            slot3selected = false;
            slot4selected = true;
            slot5selected = false;

            square.transform.position = slot4.transform.position;
        }


        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            slot1selected = false;
            slot2selected = false;
            slot3selected = false;
            slot4selected = false;
            slot5selected = true;

            square.transform.position = slot5.transform.position;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
    


    
        
    
        // Test
        if (thePlayer.useController == true)
        {
            if(Input.GetAxisRaw("HorizontalDpad") < 0)
            {
                slot1selected = true;
                slot2selected = false;
                slot3selected = false;
                slot4selected = false;
                slot5selected = false;

                square.transform.position = slot1.transform.position;
            }

            if (Input.GetAxisRaw("VerticalDpad") > 0)
            {
                slot1selected = false;
                slot2selected = true;
                slot3selected = false;
                slot4selected = false;
                slot5selected = false;

                square.transform.position = slot2.transform.position;
            }

            if (Input.GetAxisRaw("HorizontalDpad") > 0)
            {
                slot1selected = false;
                slot2selected = false;
                slot3selected = true;
                slot4selected = false;
                slot5selected = false;

                square.transform.position = slot3.transform.position;
            }

            if (Input.GetAxisRaw("VerticalDpad") < 0)
            {
                slot1selected = false;
                slot2selected = false;
                slot3selected = false;
                slot4selected = true;
                slot5selected = false;

                square.transform.position = slot4.transform.position;
            }

            if (Input.GetKey(KeyCode.Joystick1Button6))
            {
                slot1selected = false;
                slot2selected = false;
                slot3selected = false;
                slot4selected = false;
                slot5selected = true;

                square.transform.position = slot5.transform.position;
            }
            /*
            if (square.transform.position == slot1.transform.position)
            {
                if (Input.GetKeyDown(KeyCode.Joystick1Button5))
                {
                    slot1selected = false;
                    slot2selected = true;
                    slot3selected = false;
                    slot4selected = false;
                    slot5selected = false;
                    
                    square.transform.position = slot2.transform.position;
                }


            }

        */
            /*
                if (square.transform.position == slot2.transform.position)
                {
                if (Input.GetKey(KeyCode.Joystick1Button5))
                {


                    slot1selected = false;
                    slot2selected = false;
                    slot3selected = true;
                    slot4selected = false;
                    slot5selected = false;
                }
                    
                    square.transform.position = slot3.transform.position;
                }
            */
        }
        /*
        if (thePlayer.useController == true && slot2selected == true)
        {
            
        }
        */
        /*
        if (thePlayer.useController == true && slot3selected == true)
        {
            if (Input.GetKey(KeyCode.Joystick1Button5))
            {
                slot1selected = false;
                slot2selected = false;
                slot3selected = false;
                slot4selected = true;
                slot5selected = false;

                square.transform.position = slot4.transform.position;
            }
        }

        if (thePlayer.useController == true && slot4selected == true)
        {
            if (Input.GetKey(KeyCode.Joystick1Button5))
            {
                slot1selected = false;
                slot2selected = false;
                slot3selected = false;
                slot4selected = false;
                slot5selected = true;

                square.transform.position = slot5.transform.position;
            }
        }
        */
    }

    void garb()
    {
        if (square.transform.position == slot1.transform.position)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button5))
            {
                slot1selected = false;
                slot2selected = true;
                slot3selected = false;
                slot4selected = false;
                slot5selected = false;

                square.transform.position = slot2.transform.position;
            }


        }
    }

    void garb2()
    {
        if (square.transform.position == slot2.transform.position)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button5))
            {
                slot1selected = false;
                slot2selected = false;
                slot3selected = true;
                slot4selected = false;
                slot5selected = false;

                square.transform.position = slot3.transform.position;
            }


        }
    }
}
