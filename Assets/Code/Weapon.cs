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
	}

    void Fire()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            //.SetActive(true);
            nextFire = Time.time + fireRate;
            Debug.Log("Fire!");
        }
    }
}
