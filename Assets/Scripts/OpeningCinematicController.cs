using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCinematicController : MonoBehaviour {

    public string MainMenuSceneName = "MainMenu";
    public float CinematicWaitTime = 10f;

	// Use this for initialization
	void Start () {

        StartCoroutine(PlayCinematic(CinematicWaitTime));

	}
	
	IEnumerator PlayCinematic(float _waitTime)
    {
        yield return new WaitForSeconds(_waitTime);
        GameStateManager.Instance.ChangeScene(MainMenuSceneName);
    }
}
