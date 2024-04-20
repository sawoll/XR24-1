using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Part1_Collider1 : MonoBehaviour
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
            print("Panel2 Moving Down");
            animator.SetInteger("Controll", 2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Panel2 Moving up");
        animator.SetInteger("Controll", 1);

    }
}
