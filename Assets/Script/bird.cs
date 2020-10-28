﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public GameObject gameover, skor, emas, perak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void  OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "grd"){
            GameObject.Find("hit").GetComponent<AudioSource> ().Play();
            skor.SetActive(false);
            gameover.SetActive(true);
            if (PlayerPrefs.GetInt("highscore")<skor.GetComponent<skor> ().score){
                PlayerPrefs.SetInt("highscore", skor.GetComponent<skor>().score);
            }
            if (skor.GetComponent<skor> ().score > 10){
                emas.SetActive(true);
            } else if (skor.GetComponent<skor> ().score >=1){
                perak.SetActive(true);
            }
            Time.timeScale = 0;
        }
        if (other.gameObject.name == "addScore"){
            GameObject.Find("point").GetComponent<AudioSource> ().Play();
            skor.GetComponent<skor> ().score++;
        }
    }
}
