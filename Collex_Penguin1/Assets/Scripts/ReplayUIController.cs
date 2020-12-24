using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayUIController : MonoBehaviour
{
    public GameObject replayButton;
    public GameObject exitButton;
    public GameObject replaySmall;

    

    void OnEnable() {

       // SwitchToReplay();
    }

    private void OnDisable() {

       // HideUI();

    }

    public void SwitchToReplay() {
        print("signalrecived!");
        replayButton.SetActive(true);
        exitButton.SetActive(true);
        replaySmall.SetActive(false);
    }

    public void SwitchToReplaySmall()
    {
        replayButton.SetActive(false);
        exitButton.SetActive(false);
        replaySmall.SetActive(true);

    }


    public void HideUI()
    {
        replayButton.SetActive(false);
        exitButton.SetActive(false);
        replaySmall.SetActive(false);

    }




}
