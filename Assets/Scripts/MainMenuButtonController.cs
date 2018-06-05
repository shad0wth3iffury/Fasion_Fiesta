using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonController : MonoBehaviour {

    public void LoadSceneByName(string _sceneName)
    {
        GameStateManager.Instance.ChangeScene(_sceneName);
    }

}
