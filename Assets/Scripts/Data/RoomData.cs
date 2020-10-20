using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomData : Singleton<RoomData>
{
    public string roomId;
    public string playerId;

    private string _otherUserId;

    public string OtherUserId
    {
        get
        {
            return _otherUserId;
        }
        set
        {
            _otherUserId = value;
        }
    }

    private string _otherUserName;
    public string OtherUserName
    {
        get
        {
            return _otherUserName;
        }
        set
        {
            _otherUserName = value;
        }
    }

    private int _otherScore;
    public int OtherScore
    {
        get
        {
            return _otherScore;
        }
        set
        {
            _otherScore = value;
        }
    }

    private string _turn = "PlayerA";
    public string Turn
    {
        get
        {
            return _turn;
        }
        set
        {
            _turn = value;
        }
    }

    private string _result;
    public string Result
    {
        get
        {
            return _result;
        }
        set
        {
            _result = value;
        }
    }

    public List<Room> roomList = new List<Room>();

    private bool _playerAReady;
    public bool PlayerAready
    {
        get
        {
            return _playerAReady;
        }
        set
        {
            _playerAReady = value;
        }
    }

    private bool _playerBReady;
    public bool PlayerBready
    {
        get
        {
            return _playerBReady;
        }
        set
        {
            _playerBReady = value;
        }
    }
}
