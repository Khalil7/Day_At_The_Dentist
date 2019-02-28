using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchScenes : MonoBehaviour
{
    public void switchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
