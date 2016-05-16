using UnityEngine;
using System.Collections;


public class GameManagerMaster : MonoBehaviour 
{
    public delegate void GameManagerEventHandler();
    public event GameManagerEventHandler MenuToggleEvent;
    public event GameManagerEventHandler InventoryUIToggleEvent;
    public event GameManagerEventHandler RestartLevelEvent;
    public event GameManagerEventHandler MenuGoToMenuSceneEvent;
    public event GameManagerEventHandler GameOverEvent;

    public bool isGameOver;
    public bool isInventoryUIOn;
    public bool isMenuOn;

    public void CallEventMenuToggle()
    {
        if (MenuToggleEvent != null)
        {
            MenuToggleEvent();
        }
    }

    public void CallEventInventoryUIToggle()
    {
        if (InventoryUIToggleEvent != null)
        {
            InventoryUIToggleEvent();
        }
    }

    public void CallEventRestartLevel()
    {
        if (RestartLevelEvent != null)
        {
            RestartLevelEvent();
        }
    }

    public void CallEventGoToMenuScene()
    {
        if (MenuGoToMenuSceneEvent != null)
        {
            MenuGoToMenuSceneEvent();
        }
    }

    public void CallEventGameOver()
    {
        if (GameOverEvent != null)
        {
            isGameOver = true;
            GameOverEvent();
        }
    }


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
