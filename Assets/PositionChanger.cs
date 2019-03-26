using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : MonoBehaviour
{
    // OnClick functions will only work with certain parameters. Believe it only accepts one
    public void ChangePosition(string place)
    {
        if(place == "dental")
        {
            GameObject.Find("MixedRealityCameraParent").transform.position = new Vector3(-3, 3.5f, 3);
        }

        if(place =="help screen")
        {
            GameObject.Find("MixedRealityCameraParent").transform.position = new Vector3(0, 0, 1094);
            GameObject.Find("MixedRealityCameraParent").transform.Rotate(0, 180, 0);
        }

        if(place == "start")
        {
            GameObject.Find("MixedRealityCameraParent").transform.position = new Vector3(0, 0, 2309);
            GameObject.Find("MixedRealityCameraParent").transform.Rotate(0, 180, 0);
        }
    }
}
