﻿using UnityEngine;
using System.Collections;

public class SwitchWeapon : MonoBehaviour {

    public GameObject Primary;
    public GameObject Secondary;

    // Use this for initialization
    void Start () {

        Primary.SetActive(true);
        Secondary.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {

        Switch();
	
	}

    void Switch()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Primary.active)
            {
                Primary.SetActive(false);
                Secondary.SetActive(true);
            }
            else
            {
                Primary.SetActive(true);
                Secondary.SetActive(false);
            }

            Debug.Log("Switch");
        }
    }
}
