using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField emailForm;
    public InputField passwordForm;

    public Button loginButtonForm;

    private AuthManager auth;

    private UserData user;

    private void Awake()
    {
        auth = AuthManager.Instance;
        user = UserData.Instance;
    }

    void Start()
    {
        user.gameState = GameState.Login;

        loginButtonForm.onClick.AddListener(DoLogin);

    }

    void DoLogin()
    {
        Debug.Log("Loginde");

        string email = emailForm.text;
        string password = passwordForm.text;

        auth.Login(email, password);
    }
}
