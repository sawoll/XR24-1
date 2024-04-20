using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W4_hw_AnimationController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        print("X for MENU");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(animator.GetInteger("Controll") == 0 || animator.GetInteger("Controll") == 2)
            {
                print("Panel Moving Up");
                animator.SetInteger("Controll", 1);
            }else if(animator.GetInteger("Controll") == 1)
            {
                print("Panel Moving Down");
                animator.SetInteger("Controll", 2);
            }
        }
    }
}
