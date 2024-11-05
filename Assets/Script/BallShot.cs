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
        //‚Í‚¶‚ß‚Í‚·‚®‚É¶¬
       time = 5f;
    }

    void Update()
    {
        time += Time.deltaTime;


        //‰½•b‚©Œo‰ß‚µ‚½‚ç¶¬‚·‚é‚½‚ß
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
            // ‰Ÿ‚µ‚Ä‚¢‚éŠÔspeed‚ð‰ÁŽZ
            speed += 20 * Time.deltaTime * 100; // Time.deltaTime‚ðŽg‚¤‚±‚Æ‚ÅƒtƒŒ[ƒ€ƒŒ[ƒg‚ÉˆË‘¶‚µ‚È‚¢‰ÁŽZ
            //regidbody‚Ì’âŽ~
            ballRigidbody.velocity = Vector3.zero;
            //d—Í‚Ì’âŽ~
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
