using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed1 = 99.9f;
    // Update is called once per frame
    void Update()
    {
        //�ƶ�
        transform.position -= Vector3.forward * speed1 * Time.deltaTime;
        //���������λ�ú�
        if (transform.position.z < -20)
        {
            //��������
            Destroy(gameObject);
        }
    }
    //��ײ���
    private void OnTriggerEnter(Collider other)
    {
        //��������ӵ�
        if (other.tag == "Bullet")
        {
            //��ӷ���
            UIManager.Instance.Add();
            //��������
            Destroy(gameObject);
        }
    }
}
