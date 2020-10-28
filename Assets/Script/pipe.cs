using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    float Ypipe;
    public float kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        Ypipe = Random.Range (-4, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1){
            transform.localPosition  = new Vector3 (transform.localPosition.x-kecepatan, Ypipe, 0);
        } 
    }
}
