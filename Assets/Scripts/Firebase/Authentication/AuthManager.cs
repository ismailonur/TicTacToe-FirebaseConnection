using Firebase.Auth;
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

    public void Signup(string username, string email, string password)
    {
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                return;
            }
            if (task.IsFaulted)
            {
                return;
            }
            FirebaseUser newUser = task.Result;
            DB.user.userId = newUser.UserId;
            DB.CreateUser(username);
        });
    }

    public void Login(string email, string password)
    {

    }

    public void AutoLogin()
    {

    }

}
