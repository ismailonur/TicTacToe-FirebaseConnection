﻿using Firebase.Auth;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthManager : Singleton<AuthManager>
{
    public FirebaseAuth auth;

    public DBManager DB;

    public UserData user;

    private void Awake()
    {
        auth = FirebaseAuth.DefaultInstance;

        DB = DBManager.Instance;
        user = UserData.Instance;
    }

    void Start()
    {
        
    }

    public void Signup()
    {

    }

    public void Login()
    {

    }

    public void AutoLogin()
    {

    }

}