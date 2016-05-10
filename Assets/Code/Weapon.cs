using UnityEngine;
using System.Collections;

public class Weapon: MonoBehaviour {


    public int rounds = 0;
    public float fireRate = 0.3f;
    public float nextFire;
    RaycastHit hit;
    //public GameObject flare;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //flare.SetActive(false);
        Fire();
        //Reload();
        Melee();
	}

    void Fire()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {

            //.SetActive(true);
            nextFire = Time.time + fireRate;
            GetComponent<Animation>().Play("Fire1");
            Debug.Log("Fire!");
        }
    }

    /*void Reload()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<Animation>().Play("Reload");
        }
    }
     */

    void Melee()
    {
        if (Input.GetKey(KeyCode.F))
        {
            GetComponent<Animation>().Play("Melee");
        }
    }

}
