using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W03_MouseEvent : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        print(gameObject.name);
    }

    private void OnMouseUp()
    {
        print(transform.position); // 누르면 오브젝트 위치 출력.
    }
}
