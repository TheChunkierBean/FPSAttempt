using UnityEngine;
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
	
	}

    void Switch()
    {
        
        if (Input.GetKeyDown("Q"))
        {
            Primary.SetActive(false);
            Secondary.SetActive(true);

            Debug.Log("Switch");
        }
    }
}
