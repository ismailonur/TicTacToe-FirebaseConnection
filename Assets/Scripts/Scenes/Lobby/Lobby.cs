using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    private DBManager DB;

    private UserData user;
    private RoomData room;

    public Dropdown gameListForm;
    public Button joinRoomButton;
    public Button createRoomButton;

    private void Awake()
    {
        DB = DBManager.Instance;

        user = UserData.Instance;
        room = RoomData.Instance;

        user.gameState = GameState.Lobby;
    }

    void Start()
    {
        joinRoomButton.onClick.AddListener(JoinRoom);
        createRoomButton.onClick.AddListener(CreateRoom);
    }

    void JoinRoom()
    {
        Debug.Log("Join Room");

        string _roomId = gameListForm.options[gameListForm.value].text;
        DB.SendInvite(_roomId);
    }

    void CreateRoom()
    {
        Debug.Log("Create Room");

        DB.CreateRoom();
    }

    public void RefreshLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
