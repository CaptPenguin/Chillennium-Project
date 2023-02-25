using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    int multiplier = 2;
    int streak = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        
    }

    public int GetScore(){
        return 100*multiplier;
    }
}
