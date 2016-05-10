using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    private PlayerMaster playerMaster;
    public int playerHealth;
    public Text healthText;

    void OnEnable()
    {


    }

    void OnDisable()
    {

    }

    void Start ()
    {
	
	}

    void SetInitialReferences()
    {

    }

    IEnumerator TestHealthDeduction()
    {
        yield return new WaitForSeconds(4);
        DecreaseHealth(100);
    }

    void DecreaseHealth(int healthChange)
    {

    }

    void IncreaseHealth(int healthChange)
    {

    }

    void SetUI()
    {

    }

    void Update ()
    {
	
	}
}
