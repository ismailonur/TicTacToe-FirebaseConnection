﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    public string roomId;
    public string hostId;

    public Room(string _roomId, string _hostId)
    {
        this.roomId = _roomId;
        this.hostId = _hostId;
    }
}
