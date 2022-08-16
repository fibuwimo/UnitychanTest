using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController2 : MonoBehaviour
{
    //目的地となるオブジェクトのトランスフォーム格納用
    public Transform [] targets;
    //エージェントとなるオブジェクトのNavMeshAgent格納用
    public NavMeshAgent agent;
    public int index=0;

    // Use this for initialization
    void Update()
    {
        //目的地となる座標を設定する
        agent.destination = targets[index].position;
    }

    
}