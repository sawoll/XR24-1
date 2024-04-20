using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class EX_MultiPlayer_PlayerMove : MonoBehaviourPunCallbacks
{
    public TMP_Text PlayerName;
    public Transform Canvas;

    private void Start()
    {
        print("NickName:" + PhotonNetwork.NickName);
        PlayerName.text = photonView.Owner.NickName;
        if (photonView.IsMine)
        {
            PlayerName.color = Color.green;
        }
        else
        {
            PlayerName.color = Color.red;
        }
    }
    void Update()
    {
        if (photonView.IsMine)
        {
            float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 500f;
            float v = Input.GetAxisRaw("Vertical") * Time.deltaTime * 3f;
            transform.Rotate(0, h, 0);
            transform.Translate(0, 0, v);
        }
        Canvas.forward = Camera.main.transform.forward; // 캔버스의 정면을 카메라의 정면과 동일하게 일치시킨다.
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "FallDetector") // falldetecter라는 collider에 닿으면
        {
            print("collision:falling");
            transform.position = Random.insideUnitCircle * 2.0f; // 리스폰!
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FallDetector")
        {
            print("trigger:falling");
            transform.position = Random.insideUnitCircle * 2.0f;
        }
    }
}
