using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_Door_AnimationControl : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Robot_Transform")
        {
            print("trigger enter");
            animator.SetInteger("Controll", 1); // 컨트롤 변수에 1을 할당해서 문이 열리게 한다.
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Robot_Transform")
        {
            print("trigger exit");
            animator.SetInteger("Controll", 2); // 컨트롤 변수에 1을 할당해서 문이 열리게 한다.
        }
    }
}
