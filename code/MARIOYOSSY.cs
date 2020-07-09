using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MARIOYOSSY : MARIO{
    public GameObject MARIO;
    public Transform spawnpoint;
    //基本性能はマリオと同じ
    //ちょっと高めに飛ぶ
    //敵にあたると死なずにマリオに
    public void DIE(){
        Destroy(gameObject,0);  
        GameObject NEWMARIO=Instantiate(MARIO,spawnpoint.position,Quaternion.identity) as GameObject;  
    }
}
