using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject X;
    public GameObject O;

    private DBManager DB;
    private RoomData room;

    public bool status = false;

    void Start()
    {
        DB = DBManager.Instance;
        room = RoomData.Instance;
    }

    public void DoAction()
    {
        if(room.playerId == "PlayerA" && room.Turn == "PlayerA" && !status)
        {
            DB.DoAction(this.gameObject.name);
        }
        else if (room.playerId == "PlayerB" && room.Turn == "PlayerB" && !status)
        {
            DB.DoAction(this.gameObject.name);
        }
    }


}
