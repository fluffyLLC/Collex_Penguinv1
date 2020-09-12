using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBowAnim : MonoBehaviour
{
    Animator animator;
    public float time = 2;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("PlayAnimation", time);

    }

    void PlayAnimation()
    {
        animator.SetTrigger("PlayBow");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
