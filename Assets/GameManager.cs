using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    // Start is called before the first frame update
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            print("went into end function");
            UnityEditor.EditorApplication.Exit(0);
        }
    }
}
