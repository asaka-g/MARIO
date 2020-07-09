using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mush : Enemy{
    float move=0.02f;
    //Enemyにおいてすでに基本的な動作は入っている
    void Update(){
        //クリボー自身の動き
        Vector3 pos=transform.position;
        pos.x-=move;
        transform.position=pos;
        //落ちたら死ぬ
        if(pos.y<-10){
            DIE_OUT();
        }
    }
}