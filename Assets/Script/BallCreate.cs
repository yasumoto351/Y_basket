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
        //�͂��߂͂����ɐ���
        time = 5f;
    }

    void Update()
    {
        time += Time.deltaTime;


        //���b���o�߂����琶�����邽��
        if (time > span)
        {
            Instantiate(sphere, transform.position + new Vector3(0,1,0), Quaternion.identity);
            time = 0f;
        }



        

    }
}
