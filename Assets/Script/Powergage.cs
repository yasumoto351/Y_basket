using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;

public class Powergage : MonoBehaviour
{
  
    private float maxspeed = 3000;
    private float speed    = 0;
    //Sliderを入れる
    public Slider slider;

    BallShot ballshot ;


    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        speed = maxspeed;
        Debug.Log("Start currentHp : " + speed);

        ballshot = GetComponent<BallShot>();
    }


    void Update()
    {
        
        maxspeed = ballshot.maxspeed;

        speed = ballshot.speed;

        slider.value = speed / maxspeed;


    }






    ////ColliderオブジェクトのIsTriggerにチェック入れること。
    //private void OnTriggerEnter(Collider collider)
    //{
    //    //Enemyタグのオブジェクトに触れると発動
    //    if (collider.gameObject.tag == "Enemy")
    //    {
    //        //ダメージは1〜100の中でランダムに決める。
    //        int damage = Random.Range(1, 100);
    //        Debug.Log("damage : " + damage);

    //        //現在のHPからダメージを引く
    //        currentHp = currentHp - damage;
    //        Debug.Log("After currentHp : " + currentHp);

    //        //最大HPにおける現在のHPをSliderに反映。
    //        //int同士の割り算は小数点以下は0になるので、
    //        //(float)をつけてfloatの変数として振舞わせる。

    //        slider.value = (float)currentHp / (float)maxHp; ;
    //        Debug.Log("slider.value : " + slider.value);
    //    }
    //}
}