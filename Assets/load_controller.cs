using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class load_controller : MonoBehaviour
{

    private void Awake()
    {
        GameObject.Find("MixedRealiyCameraParent").GetComponent<MixedRealityTeleport>();
    }
}
