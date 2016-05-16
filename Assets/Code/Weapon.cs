using UnityEngine;
using System.Collections;

public class Weapon: MonoBehaviour {


    public int rounds = 0;
    public float fireRate = 0.3f;
    public float nextFire;
    RaycastHit hit;
    private Animator anim;
    public GameObject crosshair;
    //public GameObject flare;


	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        //flare.SetActive(false);
        crosshair.SetActive(true);
        Fire();
        Reload();
        Melee();
        Throw();
	}


    void Fire()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            if (anim != null)
            {
                anim.SetTrigger("Fire");
                nextFire = Time.time + fireRate;
                Debug.Log("Fire!");
            }

        }
    }

    void Reload()
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (anim != null)
            {
                anim.SetTrigger("Reload");
            }
        }
    }


    void Melee()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (anim != null)
            {
                anim.SetTrigger("Melee");
            }
        }
    }

    void Throw()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (anim != null)
            {
                anim.SetTrigger("Throw");
            }
        }
    }

}
