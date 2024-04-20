using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class W03_Button : MonoBehaviour
{
    public TMP_Text InputText, OutputText;
    // Start is called before the first frame update
    public void OnClick_Test()
    {
        print("button clicked");
    }

    public void OnClick_SetText()
    {
        OutputText.text = InputText.text;
    }
}
