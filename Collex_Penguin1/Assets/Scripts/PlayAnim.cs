using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    public Animator penguinAnim;
    public Animator umbrella;
    public float time = 1;
    public int touchCountPrev = 0;

    // Start is called before the first frame update

    private void Awake()
    {
      //  umbrella = GetComponent<Animator>();
        Invoke("PlayAnimation", time);
    }

    void Start()
    {

    }

    void PlayAnimation()
    {
        umbrella.SetTrigger("Fold");
        penguinAnim.SetTrigger("Jump");

    }


    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > touchCountPrev) {
            penguinAnim.SetTrigger("Reset");
            umbrella.SetTrigger("Reset");
            Invoke("PlayAnimation", 0);

            touchCountPrev = Input.touchCount;

        }


    }



    public void OnGUI()
    {
        GUI.color = Color.red;
        print("GUIRunning");
        GUI.Label(new Rect(0, 0, 100, 100), "Hello");// Input.touchCount.ToString());
        GUILayout.Label(Input.touchCount.ToString());
    }
}
