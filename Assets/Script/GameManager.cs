using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject _gameOverUI;

    public Button restartButton;
    void Start()
    {
        restartButton.onClick.AddListener(RestartScene);
    }

    void Update()
    {
    
    }

    public void GameOver()
    {
        _gameOverUI.SetActive(true);
        restartButton.enabled = true;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
