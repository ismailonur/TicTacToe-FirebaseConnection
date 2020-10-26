using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    private UserData user;
    private RoomData room;
    private BoardData board;

    private DBManager DB;

    public Text resultText;

    private void Awake()
    {
        user = UserData.Instance;
        room = RoomData.Instance;
        board = BoardData.Instance;

        DB = DBManager.Instance;

        user.gameState = GameState.Result;
    }

    void Start()
    {
        PrintResult();
        CloseSession();
    }

    void PrintResult()
    {
        if(room.Result == "PlayerA")
        {
            if(room.playerId == "PlayerA")
            {
                resultText.text = "KAZANDIN!";
                DB.EditScore();
            }
            else if (room.playerId == "PlayerB")
            {
                resultText.text = "KAYBETTİN!";
            }
        }
        else if(room.Result == "PlayerB")
        {
            if(room.playerId == "PlayerA")
            {
                resultText.text = "KAYBETTİN!";
            }
            else if (room.playerId == "PlayerB")
            {
                resultText.text = "KAZANDIN!";
                DB.EditScore();
            }
        }
    }

    public void CloseSession()
    {
        DB.CloseListenRoom();
        DB.RemoveRoom();

        if(room.playerId == "PlayerA")
        {
            DB.CloseListenInvites();
            DB.RemoveAllInvites();
        }

        if(room.playerId == "PlayerB")
        {
            DB.CloseListenAcceptedInvites();
            DB.RemoveAllAcceptedInvites();
        }

        room.roomId = "";
        room.playerId = "";
        room.OtherUserId = "";
        room.OtherUserName = "";
        room.OtherScore = 0;
        room.Turn = "PlayerA";
        room.Result = "";
        room.roomList.Clear();
        room.roomList = new List<Room>();
        room.PlayerAready = false;
        room.PlayerBready = false;

        board.lastPlayed = "";
        board.S1 = "";
        board.S2 = "";
        board.S3 = "";
        board.S4 = "";
        board.S5 = "";
        board.S6 = "";
        board.S7 = "";
        board.S8 = "";
        board.S9 = "";
    }

    public void GoLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
