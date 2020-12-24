using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayAnim : MonoBehaviour
{

    public ReplayUIController UI;
    public Animator anim;
    public PlayableDirector timeline;
    //public Animator umbrella;
    public float time = 1;
    public int touchCountPrev = 0;

    // Start is called before the first frame update

    private void Awake()
    {
      //  umbrella = GetComponent<Animator>();
       // Invoke("PlayAnimation", time);
    }

    void Start()
    {

    }

    void PlayAnimation()
    {
        timeline.Play();
        //timeline.
        //anim.SetTrigger("Play");
        //penguinAnim.SetTrigger("Jump");

    }


    // Update is called once per frame
    //void Update()
    //{
    //}


    public void ResetAndPlay()
    {
        UI.HideUI();
        //penguinAnim.SetTrigger("Reset");
        //umbrella.SetTrigger("Reset");
        //Invoke("PlayAnimation", 0);
        PlayAnimation();
        print("replay!");

        //touchCountPrev = Input.touchCount;
    }


    /*
    public void OnGUI()
    {
        GUI.color = Color.red;
        print("GUIRunning");
        GUI.Label(new Rect(0, 0, 100, 100), "Hello");// Input.touchCount.ToString());
        GUILayout.Label(Input.touchCount.ToString());
    }
    */
}
