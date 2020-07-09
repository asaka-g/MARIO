using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block1 : block23{
    public GameObject coin;
    public float power;
    private float deleteTime=10.0f;
    float move=-0.03f;
    float run=-0.02f;
    //親オブジェクトのnumが1のときにコインを出す
    void Update(){
        //今回はあきらめてもう一回書く
        Vector3 pos=transform.position;
        //マリオの動きに合わせて左右する
        if(Input.GetKey(KeyCode.LeftArrow)){
            pos.x-=move;
            if(Input.GetKey(KeyCode.LeftShift)){
                pos.x-=run;
            }
        }else if(Input.GetKey(KeyCode.RightArrow)){
            pos.x+=move;
            if(Input.GetKey(KeyCode.LeftShift)){
                pos.x+=run;
            }
        }
        transform.position=pos;
    }
}
