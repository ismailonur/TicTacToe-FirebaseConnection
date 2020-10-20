﻿using Firebase;
using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    // auth
    // public AuthManager auth;

    // Data Class
    public UserData user;
    public RoomData room;
    public BoardData board;

    public DatabaseReference usersReference;
    public DatabaseReference roomsReference;
    public DatabaseReference invitesReference;
    public DatabaseReference acceptedInvitesReference;

    private void Awake()
    {
        user = UserData.Instance;
        room = RoomData.Instance;
        board = BoardData.Instance;
    }

    void Start()
    {
        Initialization();
    }

    void Initialization()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if(dependencyStatus == DependencyStatus.Available)
            {
                usersReference = FirebaseDatabase.DefaultInstance.GetReference("Users");
                roomsReference = FirebaseDatabase.DefaultInstance.GetReference("Rooms");
                invitesReference = FirebaseDatabase.DefaultInstance.GetReference("Invites");
                acceptedInvitesReference = FirebaseDatabase.DefaultInstance.GetReference("AcceptedInvites");
            }
            else
            {
                Debug.LogError("DB Bağlantısı Kurulamadı");
            }

        });
    }

    public void CreateUser()
    {

    }

    public void GetUserInformation()
    {

    }

    public void CreateRoom()
    {

    }

    public void GetRoomList()
    {

    }

    public void SendInvite()
    {

    }

    public void AcceptInvite()
    {

    }

    public void SetResult()
    {

    }

    public void SetReady()
    {

    }

    public void EditScore()
    {

    }

    public void DoAction()
    {

    }

    public void GetOtherUserInformation()
    {

    }

    public void RemoveAllInvites()
    {

    }

    public void RemoveAllAcceptedInvites()
    {

    }

    public void RemoveRoom()
    {

    }

    public void OpenListenRoom()
    {

    }

    public void ListenRoom()
    {

    }

    public void CloseListenRoom()
    {

    }

    public void OpenListenInvites()
    {

    }

    public void ListenInvites()
    {

    }

    public void CloseListenInvites()
    {

    }

    public void OpenListenAcceptedInvites()
    {

    }

    public void ListenAcceptedInvites()
    {

    }

    public void CloseListenAcceptedInvites()
    {

    }

    public void FinishGame()
    {

    }
}