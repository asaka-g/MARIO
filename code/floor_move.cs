using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_move : MonoBehaviour{
    float move=-0.03f;
    float run=-0.02f;
    /*もうこれは使わない
    void Update(){
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
    }*/
}
