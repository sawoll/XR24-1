using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_initial : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        print("��ȭ���ڴ��б� �Ұ� ����");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (animator.GetInteger("Controll") == 0 || animator.GetInteger("Controll") == 2)
            {
                print("Panel1 Moving Down");
                animator.SetInteger("Controll", 1);
            }
            else if (animator.GetInteger("Controll") == 1)
            {
                print("Panel1 Moving Up");
                animator.SetInteger("Controll", 2);
            }

        }
    }
}
