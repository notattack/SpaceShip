using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPointControl : MonoBehaviour
{
    //关联敌机预制件
    public GameObject EnemyPre;
    //生成敌机计时器
    private float timer = 0;
    //生成敌机CD
    private float CD = 1f;
    // Update is called once per frame
    void Update()
    {
        //计时器开始计时
        timer+=Time.deltaTime;
        //如果计时器时间到
        if(timer > CD)
        {
            //重置计时器
            timer = 0;
            //重置CD
            CD = Random.Range(0.3f,3f);
            //随机敌机生成位置
            Vector3 pos = transform.position + Vector3.left * Random.Range(-10f, 10f) + Vector3.up * Random.Range(-10f, 10f);
            //实例化敌机
            Instantiate(EnemyPre, pos, transform.rotation);
        }
    }
}
