using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JyunkaiEnemy : MonoBehaviour
{
    public EnemyController2 EneCon2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("通過");
        if (other.gameObject.tag == "t0")
        {
            EneCon2.index = 1;
        }
        if (other.gameObject.tag == "t1")
        {
            EneCon2.index = 0;
        }
    }
}
