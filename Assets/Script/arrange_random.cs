using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrange_random : MonoBehaviour
{
    public float ran_z;
    public float ran_x;
    public float timeOut;
    private float timeElapsed;



    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {

        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // Do anything
            ran_z = Random.Range(10f, 100f);
            ran_x = Random.Range(-10f, 10f);

            transform.position = new Vector3(ran_x, 10 , ran_z);

            timeElapsed = 0.0f;
        }


    }
}
