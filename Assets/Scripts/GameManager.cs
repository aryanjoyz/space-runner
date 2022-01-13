using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject player;
    public GameObject Spawner;
    public GameObject health;
    public GameObject score;
    public GameObject healthDisplay;
    public GameObject scoreDisplay;
    public GameObject cloudBG;
    public GameObject cloudBG2;
    public GameObject cloudBG3;
    public enum State { MENU, INIT, PLAY }
    State _state;

    public void PlayClicked()
    {
        SwitchState(State.INIT);
    }
    void Start()
    {
        SwitchState(State.MENU);
    }

    public void SwitchState(State newState)
    {
        EndState(); 
        BeginState(newState);
    }

    void BeginState(State newState)
    {
        switch (newState)
        {
            // menu 
            case State.MENU:
                panelMenu.SetActive(true);
                player.SetActive(false);
                Spawner.SetActive(false);
                health.SetActive(false);
                score.SetActive(false); ;
                healthDisplay.SetActive(false);
                scoreDisplay.SetActive(false);
                cloudBG.SetActive(false);
                cloudBG2.SetActive(false);
                cloudBG3.SetActive(false);
                break;
            
            // in game
            case State.INIT:
                player.SetActive(true);
                Spawner.SetActive(true);
                health.SetActive(true);
                score.SetActive(true); ;
                healthDisplay.SetActive(true);
                scoreDisplay.SetActive(true);
                cloudBG.SetActive(true);
                break;

            case State.PLAY:
                break;
        }
    }
    void Update()
    {
        switch (_state)
        {
            case State.MENU:
                break;

            case State.INIT:
                break;

            case State.PLAY:
                break;
        }
    }
    void EndState()
    {
        switch (_state)
        {
            case State.MENU:
                panelMenu.SetActive(false);
                break;

            case State.INIT:
                break;

            case State.PLAY:
                break;
        }
    }
}
