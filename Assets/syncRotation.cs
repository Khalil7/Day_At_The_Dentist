using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syncRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform theParent;
    public Transform theChild;
    void Start()
    {
        theChild.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
