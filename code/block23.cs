using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class block23 : floor_move{
    public GameObject block3;
    public Transform spawnpoint;
    public int num=0;
    //マリオがブロックに当たるとそのブロックは消える
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()){
            transform.GetChild(0).gameObject.GetComponent<coinoryossy>().Reverse();
            GameObject new_block=Instantiate(block3,spawnpoint.position,Quaternion.identity) as GameObject;
            Destroy(gameObject,0);
        }
    }
}