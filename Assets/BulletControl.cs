using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed2 = 50f;
    // Start is called before the first frame update
    void Start()
    {
        //6s后自动销毁
        Destroy(gameObject,6f);
        //设定一个速度
        GetComponent<Rigidbody>().velocity = Vector3.forward * speed2;
    }
    private void OnTriggerEnter(Collider other)
    {
        //触发后销毁自身
        Destroy(gameObject);
    }
}
