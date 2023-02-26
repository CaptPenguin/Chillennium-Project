using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    int multiplier = 2;
    int streak = 0;

    void Start()
    {
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.SetInt("LoveMeter",25);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        
    }

    public void AddStreak(){
        if(PlayerPrefs.GetInt("LoveMeter")+1<25)
            PlayerPrefs.SetInt("LoveMeter",PlayerPrefs.GetInt("LoveMeter")+1);
        streak++;
        if(streak >= 4)
            multiplier = 4;
        else if(streak >= 2)
            multiplier = 3;
        else if(streak >= 2)
            multiplier = 2;
        else
            multiplier = 1;
         UpdateGUI();
    }

    public void ResetStreak(){
        PlayerPrefs.SetInt("LoveMeter",PlayerPrefs.GetInt("LoveMeter")-2);
        if(PlayerPrefs.GetInt("LoveMeter")>0)
            Lose();
        streak=0;
        multiplier=1;
        UpdateGUI();
    }

    public void Win(){
        SceneManager.LoadScene("WIn");
    }

    void Lose(){

    }

    void UpdateGUI(){
        PlayerPrefs.SetInt("Streak",streak);
        PlayerPrefs.SetInt("Multi",multiplier);
    }

    public int GetScore(){
        return 100*multiplier;
    }
}
