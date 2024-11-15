using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    
    public float speed = 0;
    private GameObject ball;
    private Rigidbody ballRigidbody;
    private bool charge = false;
    public float maxspeed = 3000;

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
            ball = Instantiate(sphere, new Vector3(0,3,3), Quaternion.identity);
            time = 0f;
        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ball = Instantiate(sphere, transform.position, Quaternion.identity);
            ballRigidbody = ball.GetComponent<Rigidbody>();
            charge = true;
        }

        if (charge && speed < maxspeed)
        {
            // 押している間speedを加算
            speed += 20 * Time.deltaTime * 100; // Time.deltaTimeを使うことでフレームレートに依存しない加算
            //regidbodyの停止
            ballRigidbody.velocity = Vector3.zero;
            //重力の停止
            ballRigidbody.isKinematic = true;


        }

        if (charge && Input.GetKeyUp(KeyCode.Space))
        {
            charge = false;
            ballRigidbody.isKinematic = false;
            ballRigidbody.AddForce((transform.forward + new Vector3(0, 1, 0)) * speed);
            speed = 0;
            Destroy(ball, 20f);
        }

       
    }
}
