using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HW2_SceneController_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick_Trans()
    {
        SceneManager.LoadScene("HW2_1");
        print("Transition to Scene HW2_1");
    }
}
