using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField InputField;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadPlayerData();
        InputField.text = GameManager.Instance.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void OnPlayerNameChange()
    {
        GameManager.Instance.PlayerName = InputField.text;
    }
}
