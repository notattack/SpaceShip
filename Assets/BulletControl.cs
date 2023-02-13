using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed2 = 50f;
    // Start is called before the first frame update
    void Start()
    {
        //6s���Զ�����
        Destroy(gameObject,6f);
        //�趨һ���ٶ�
        GetComponent<Rigidbody>().velocity = Vector3.forward * speed2;
    }
    private void OnTriggerEnter(Collider other)
    {
        //��������������
        Destroy(gameObject);
    }
}
