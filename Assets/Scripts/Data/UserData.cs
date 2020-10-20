using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : Singleton<UserData>
{
    public GameState gameState;

    public string userId;
    public string username;

    public int score;
}
