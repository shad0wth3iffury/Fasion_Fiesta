using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour {

    public static GameStateManager Instance;
    public LevelLoader LevelLoaderScript;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

	public void ChangeScene(string _sceneName)
    {
        LevelLoaderScript.LoadSceneByName(_sceneName);
    }

}
