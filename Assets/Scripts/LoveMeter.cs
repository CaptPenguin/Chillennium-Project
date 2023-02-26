using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveMeter : MonoBehaviour
{
    float lm;
    GameObject needle;

    void Start()
    {
        needle = transform.Find("needle").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        lm=PlayerPrefs.GetInt("LoveMeter");

        needle.transform.localPosition = new Vector3((lm-25)/25,0,0);
    }
}
