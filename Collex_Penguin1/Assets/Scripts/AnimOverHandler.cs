using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOverHandler : MonoBehaviour
{

    public ReplayUIController UI;

    public void AnimationOver() {
        print("EVENT: The animation is Over " + UI);
        //UI.gameObject.SetActive(true);
        UI.SwitchToReplay();
    }
}
