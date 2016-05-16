using UnityEngine;
using System.Collections;

public class GameManagerMenu : MonoBehaviour {

    private GameManagerMaster gameManagerMaster;
    public GameObject menu;

	// Use this for initialization
	void Start () 
    {
        ToggleMenu();
	}
	
	// Update is called once per frame
	void Update () 
    {
        CheckForMenuToggleRequest();
	}

    void OnEnable()
    {
        SetInitialReferences();
        gameManagerMaster.GameOverEvent += ToggleMenu;
    }

    void OnDisable()
    {
        gameManagerMaster.GameOverEvent -= ToggleMenu;
    }

    void SetInitialReferences()
    {
        gameManagerMaster = GetComponent<GameManagerMaster>();
    }

    void CheckForMenuToggleRequest()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !gameManagerMaster.isGameOver && !gameManagerMaster.isInventoryUIOn)
        {
            ToggleMenu();
        }
    }

    void ToggleMenu()
    {
        if (menu != null)
        {
            menu.SetActive(!menu.activeSelf);
            gameManagerMaster.isMenuOn = !gameManagerMaster.isMenuOn;
            gameManagerMaster.CallEventMenuToggle();
        }
    }
}
