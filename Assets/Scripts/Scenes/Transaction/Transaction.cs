using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transaction : MonoBehaviour
{
    private DBManager DB;

    private UserData user;
    private RoomData room;

    public Text playerAReadyText;
    public Text playerBReadyText;

    public Text noticeText;

    public GameObject inviteObject;

    private void Awake()
    {
        DB = DBManager.Instance;

        user = UserData.Instance;
        room = RoomData.Instance;
    }

    void Start()
    {
        user.gameState = GameState.Transaction;
        DB.SetReady();
    }

    void Update()
    {
        
    }
}
