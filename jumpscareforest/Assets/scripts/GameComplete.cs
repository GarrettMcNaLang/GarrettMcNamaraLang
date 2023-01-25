using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{

    public static event Action gameComplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            gameComplete?.Invoke();
        }

    }
}
