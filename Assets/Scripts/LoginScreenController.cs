using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using Assets.Scripts.Models;


public class LoginScreenController : MonoBehaviour
{
    public TMP_InputField txtUsuario;
    public TMP_Text txtError;
    public TMP_InputField txtSenha;
    private IEnumerator coroutine;

    public void Login()
    {
        Debug.Log("Passou");
        var login = new LoginRequest
        {
            username = txtUsuario.text,
            password = txtSenha.text
        };

        coroutine = NetworkService.Login(login, txtError);
        StartCoroutine(coroutine);      
    }
}
