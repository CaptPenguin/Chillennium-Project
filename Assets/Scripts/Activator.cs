using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note,gm;
    SpriteRenderer sr;
    Color old;
    public bool createMode;
    public GameObject n;
    


    void Awake(){
        sr=GetComponent<SpriteRenderer>();
    }

    void Start(){
        gm=GameObject.Find("GameManager");
        old=sr.color;

    }

    void Update()
    {
        if(createMode){
            if(Input.GetKeyDown(key)){
                Instantiate(n,transform.position,Quaternion.identity);
            }
        }else{

        if(Input.GetKeyDown(key)){
            StartCoroutine(Pressed());
        }
        if(Input.GetKeyDown(key)&&active){
            Destroy(note);
            AddScore();
            active=false;
        }
    
    }
    }

    void OnTriggerEnter2D(Collider2D col){
        active = true;
        if(col.gameObject.tag=="Note")
            note=col.gameObject;
    }

    void OnTriggerExit2D(Collider2D col){
    active = false;
    }

    void AddScore(){
        PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+gm.GetComponent<GameManager>().GetScore());
    }

    IEnumerator Pressed(){
        sr.color = new Color(0,0,0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    }
}
