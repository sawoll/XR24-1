using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Transform_Translate : MonoBehaviour
{

    public Transform ObjectToTranslate;

    float translateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        Translate();
    }


    void Translate()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            ObjectToTranslate.Translate(Vector3.forward * translateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            ObjectToTranslate.Translate(-Vector3.forward * translateSpeed * Time.deltaTime);
        }
    }
}
