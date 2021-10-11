using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
    private static GameFlowManager _instance = null;

    public static GameFlowManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameFlowManager>();
            }
            return _instance;
        }
    }

    [Header("UI")]
    public UIGameOver GameOverUI;
    public UIGameOver WIN;
   
    public bool IsGameOver { get { return isGameOver; } }
    private bool isGameOver = false;
    public bool IsWin { get { return isWin; } }
    private bool isWin = false;

    private void Start()
    {
        isGameOver = false;
        isWin = false;
    }
    public void GameOver()
    {
        isGameOver = true;
        GameOverUI.Show();
    }
    public void winn()
    {
        isWin = true;
        WIN.Show();
    }

}
