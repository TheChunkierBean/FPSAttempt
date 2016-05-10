using UnityEngine;
using System.Collections;

public class PickupWeapon : MonoBehaviour {

	

    void OnTriggerStay(Collider sphere)
    {
        if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
                Debug.Log("Gone");
                
                
            }
        Debug.Log("Entered");

    }

    
}
