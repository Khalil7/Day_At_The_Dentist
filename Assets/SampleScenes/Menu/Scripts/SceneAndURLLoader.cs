using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private SamplePauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <SamplePauseMenu> ();
    }


    public void SceneLoad(string sceneName)
	{
		//SamplePauseMenu pauseMenu = (SamplePauseMenu)FindObjectOfType(typeof(SamplePauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneName);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}

