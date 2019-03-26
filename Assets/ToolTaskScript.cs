using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTaskScript : MonoBehaviour
{
    public List<string> tools;
    public GameObject arrow;
    public List<GameObject> remove;
    public GameObject congratsTxt;
    // Start is called before the first frame update
    public void doTask(string toolName)
    {
        if (tools.Count > 0 && toolName == tools[tools.Count - 1])
        {
            KeepScore.totalScore += 1000;
            tools.RemoveAt(tools.Count - 1);
            arrow.transform.position += new Vector3(0.5f,0,0);
        }
        if (tools.Count == 0)
        {
            arrow.SetActive(false);
            gameObject.SetActive(false);
            congratsTxt.SetActive(true);

            foreach(var item in remove)
            {
                item.SetActive(false);
            }
        }
    }
}
