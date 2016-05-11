using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    private PlayerMaster playerMaster;
    public int playerHealth;
    public Text healthText;

    void OnEnable()
    {
        SetInitialReferences();
        SetUI();
        playerMaster.EventPlayerHealthDecrease += DecreaseHealth;
        playerMaster.EventPlayerHealthIncrease += IncreaseHealth;

    }

    void OnDisable()
    {
        playerMaster.EventPlayerHealthDecrease -= DecreaseHealth;
        playerMaster.EventPlayerHealthIncrease -= IncreaseHealth;
    }

    void Start ()
    {
        StartCoroutine(TestHealthDeduction());
	}

    void SetInitialReferences()
    {
        playerMaster = GetComponent<PlayerMaster>();
    }

    IEnumerator TestHealthDeduction()
    {
        yield return new WaitForSeconds(4);
        DecreaseHealth(100);
    }

    void DecreaseHealth(int healthChange)
    {
        playerHealth -= healthChange;

        if (playerHealth <= 0)
        {
            playerHealth = 0;

        }

        SetUI();
    }

    void IncreaseHealth(int healthChange)
    {
        playerHealth += healthChange;

        if (playerHealth > 100)
        {
            playerHealth = 100;
        }

        SetUI();
    }

    void SetUI()
    {
        if (healthText != null)
        {
            healthText.text = playerHealth.ToString();
        }
    }

    void Update ()
    {
	
	}
}
