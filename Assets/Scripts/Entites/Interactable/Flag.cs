using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : PlayerDetection
{
    public override void OnPlayerEneter()
    {   
        Debug.Log("you reach the end!");
        ReachEndCallback();
    }

    private void ReachEndCallback()
    {
        SceneManager.LoadSceneAsync("Settlement");
    }
}