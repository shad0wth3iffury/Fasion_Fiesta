using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour {

    public enum GameState { Play, Pause };
    GameState MyGameState = GameState.Play;
    public static GameStateManager Instance;
    public LevelLoader LevelLoaderScript;
    public float DeltaStateTime = 0;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (MyGameState == GameState.Play)
            DeltaStateTime = Time.deltaTime;
        else if (MyGameState == GameState.Pause)
            DeltaStateTime = 0f;
    }

    public void ChangeScene(string _sceneName)
    {
        LevelLoaderScript.LoadSceneByName(_sceneName);
    }

    public void SetGameStateToPause()
    {
        MyGameState = GameState.Pause;
    }

    public void SetGameStateToPlay()
    {
        MyGameState = GameState.Play;
    }

}
