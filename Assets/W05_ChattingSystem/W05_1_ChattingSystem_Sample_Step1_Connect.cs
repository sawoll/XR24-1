using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;


public class W05_1_ChattingSystem_Sample_Step1_Connect : MonoBehaviourPunCallbacks
{
    // ������¸� ǥ���ϴ� Panel
    public GameObject Panel_ConnectionStatus;
    public TMP_Text ConnectionStatus;

    // ������� �̸�(NickName)�� �Է��ϴ� Panel
    public GameObject Panel_SetUserName;
    public TMP_InputField UserNameInput;
    public GameObject UserConnectButton;

    // Chatting Interface�� �ִ� Scene ����
    public Object ChattingScene;

    void Start()
    {
        // Panel Ȱ��ȭ ����
        Panel_ConnectionStatus.SetActive(true);
        Panel_SetUserName.SetActive(false);

        // ȭ���� ũ�� ����
        Screen.SetResolution(800, 600, false); // fullscreen = false

        // GameVersio ����
        PhotonNetwork.GameVersion = "0.1";

        // ���� ���� ����: ���� ���� --> ������ ���� --> ���� ���� (Room)
        // ���ӿ� �����ϸ� ������ Ŭ���̾�Ʈ�� ������ ���� �ڵ����� ����ȭ�ϵ��� ��
        // ���� �ٲ� ��쿡�� ����ȭ��
        PhotonNetwork.AutomaticallySyncScene = true;

        // ���� ����
        print("Starting Connect Process...");
        ConnectionStatus.text = "������ �����մϴ�...";
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        print("Connected To Master");
        ConnectionStatus.text = "Master�� �����߽��ϴ�.";

        // �κ� ������. ���� OnJoinedLobby()�� �ڵ� ȣ���
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }


    public override void OnJoinedLobby()
    {
        print("Joined Lobby");
        ConnectionStatus.text = "�̸��� �Է��ϼ���.";
        Panel_SetUserName.SetActive(true);
    }

    public void OnClick_JoinOrCreateRoom()
    {
        if (string.IsNullOrEmpty(UserNameInput.text) || UserNameInput.text == "�̸��� �Է��ϼ���.")
        {
            UserNameInput.text = "�̸��� �Է��ϼ���.";
        }
        else
        {
            print("User Name:" + UserNameInput.text);
            RoomOptions ro = new RoomOptions()
            {
                IsVisible = true,
                IsOpen = true,
                MaxPlayers = 8
            };

            PhotonNetwork.NickName = UserNameInput.text;
            print("������� �̸��� " + PhotonNetwork.NickName + "�Դϴ�.");
            // ���� ������ ������. �����ϸ� OnJoinedRoom()�� �ڵ� ȣ���
            PhotonNetwork.JoinOrCreateRoom("Room", ro, TypedLobby.Default);
        }
    }

    public override void OnJoinedRoom()
    {
        print(PhotonNetwork.NickName + " has joined Room");
        string ChattingSceneName = ChattingScene.name;
        PhotonNetwork.LoadLevel(ChattingSceneName); 
    }
    
}
