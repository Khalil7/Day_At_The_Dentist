using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterDoor : MonoBehaviour
{
    public GameObject oldCongratsObject;
    public GameObject doorCongratsObject;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        doorCongratsObject.SetActive(true);
        oldCongratsObject.SetActive(false);

    }
}
