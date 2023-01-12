using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;
    public static event Action<GameState> OnGameStateChanged; 


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGamestate(GameState.Playing);
    }

    public void UpdateGamestate(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Playing:
                break;
            case GameState.Pause:
                break;
            case GameState.GameOver:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChanged?.Invoke(newState);
    }
    
    
    public enum GameState
    {
        Pause,
        Playing,
        GameOver
    }
}
