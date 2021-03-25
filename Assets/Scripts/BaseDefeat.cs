using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDefeat : MonoBehaviour
{
    private Transform PlayerBase;

    // Start is called before the first frame update
    void Start()
    {
        PlayerBase = GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerBase.childCount == 0)
            GameOver.IsPlayerDead = true;
    }
}
