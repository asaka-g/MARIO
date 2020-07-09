using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redmush : Enemy{
    public float power=1000f;
    public GameObject mush_fire;
    public Transform spawnpoint;
    private const float START_SECONDS = 0.0f;
    private const float INTERVA_SECONDS = 3.0f;
    private float deleteTime=3.0f;
    //redmushはINTERVA_SECONDSごとに火を放つ、deleteTimeで消える
    void Shoot(){
        GameObject newfire=Instantiate(mush_fire,spawnpoint.position,Quaternion.identity) as GameObject;
        newfire.GetComponent<Rigidbody2D>().AddForce((Vector3.left)*power);
        Destroy(newfire,deleteTime);
    }
    void Start(){
        InvokeRepeating("Shoot", START_SECONDS, INTERVA_SECONDS);
    }
}
