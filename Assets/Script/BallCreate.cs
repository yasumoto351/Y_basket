using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreate : MonoBehaviour
{
    [SerializeField] GameObject sphere;

    
   
    
    public float span = 5f;
    private float time = 0f;


    void Start()
    {
        //はじめはすぐに生成
        time = 5f;
    }

    void Update()
    {
        time += Time.deltaTime;


        //何秒か経過したら生成するため
        if (time > span)
        {
            Instantiate(sphere, transform.position + new Vector3(0,1,0), Quaternion.identity);
            time = 0f;
        }



        

    }
}
