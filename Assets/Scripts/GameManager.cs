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

    public void AddStreak(){
        streak++;
        if(streak >= 6){
            multiplier = 4;
        }
        else if(streak >= 4){
            multiplier = 3;
        }
        else if(streak >= 2){
            multiplier = 2;
        }
        else{
            multiplier = 1;
        }
         UpdateGUI();
    }

    public void ResetStreak(){
        streak=0;
        multiplier=1;
        UpdateGUI();
    }

    void UpdateGUI(){
        PlayerPrefs.SetInt("Streak",streak);
        PlayerPrefs.SetInt("Multi",multiplier);
    }

    public int GetScore(){
        return 100*multiplier;
    }
}
