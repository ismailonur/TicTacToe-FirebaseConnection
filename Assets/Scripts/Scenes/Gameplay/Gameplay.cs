using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    private UserData user;
    private RoomData room;
    private BoardData board;

    private DBManager DB;

    public Text NoticeText;

    public Text playerAUsername;
    public Text playerBUsername;

    public Text playerAScore;
    public Text playerBScore;

    public Image playerATurn;
    public Image playerBTurn;

    public GameObject X1;
    public GameObject O1;

    public GameObject g;

    private void Awake()
    {
        user = UserData.Instance;
        room = RoomData.Instance;
        board = BoardData.Instance;
        DB = DBManager.Instance;

        user.gameState = GameState.Gameplay;
    }

    void Start()
    {
        DB.GetOtherUserInformation();

        NoticeText.text = "Siz: " + user.username;

        if(room.playerId == "PlayerA")
        {

        }

        if(room.playerId == "PlayerB")
        {

        }
    }

    public void CheckTourConditions()
    {
        if(board.lastPlayed == "X")
        {
            g = X1;
        }
        else if(board.lastPlayed == "O")
        {
            g = O1;
        }

        // Oyunu Kazanma Şartları
    }

    public void ExitButton()
    {
        Debug.Log("Oyundan Ayrıldı");

        DB.SetResult();
    }
}
