using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPointControl : MonoBehaviour
{
    //�����л�Ԥ�Ƽ�
    public GameObject EnemyPre;
    //���ɵл���ʱ��
    private float timer = 0;
    //���ɵл�CD
    private float CD = 1f;
    // Update is called once per frame
    void Update()
    {
        //��ʱ����ʼ��ʱ
        timer+=Time.deltaTime;
        //�����ʱ��ʱ�䵽
        if(timer > CD)
        {
            //���ü�ʱ��
            timer = 0;
            //����CD
            CD = Random.Range(0.3f,3f);
            //����л�����λ��
            Vector3 pos = transform.position + Vector3.left * Random.Range(-10f, 10f) + Vector3.up * Random.Range(-10f, 10f);
            //ʵ�����л�
            Instantiate(EnemyPre, pos, transform.rotation);
        }
    }
}
