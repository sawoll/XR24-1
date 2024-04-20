using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Part1_Collider2 : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Panel3 Moving Down");
            animator.SetInteger("Controll", 2);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        print("Panel3 Moving up");
        animator.SetInteger("Controll", 1);

    }
}
