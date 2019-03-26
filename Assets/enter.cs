using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enter : MonoBehaviour
{
    public List<GameObject> enableObjects;
    public List<GameObject> disableObjects;
    public GameObject player;
    public int score;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("MixedRealityCameraParent");
    }

    private void Update()
    {
        print(calcxzDistance(player.transform.position, gameObject.transform.position));
        if (calcxzDistance(player.transform.position, gameObject.transform.position) < 0.17)
        {
            collided();
            KeepScore.totalScore += score;
            gameObject.SetActive(false);
        }
       
    }


    private void collided()
    {
        foreach(var item in enableObjects)
        {
            item.SetActive(true);
        }
        foreach (var item in disableObjects)
        {
            item.SetActive(false);
        }

    }


    private double calcxzDistance(Vector3 position1, Vector3 position2)
    {
        return Math.Pow(position1.x - position2.x, 2) + Math.Pow(position1.z - position2.z, 2);
    } 
 

    
}
