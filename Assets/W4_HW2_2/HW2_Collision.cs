using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Robot_Transform")
        {
            print(other.gameObject.name);
        }
    }
}
