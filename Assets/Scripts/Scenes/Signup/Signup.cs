using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signup : MonoBehaviour
{
    public InputField usernameForm;
    public InputField emailForm;
    public InputField passwordForm;

    public Button signupButton;

    private AuthManager auth;

    private UserData user;

    private void Awake()
    {
        auth = AuthManager.Instance;
        user = UserData.Instance;
    }

    void Start()
    {
        user.gameState = GameState.Signup;

        signupButton.onClick.AddListener(DoSignup);
    }

    void DoSignup()
    {
        Debug.Log("Signup süreci");

        string username = usernameForm.text;
        string email = emailForm.text;
        string password = passwordForm.text;

        auth.Signup(username, email, password);
    }
}
