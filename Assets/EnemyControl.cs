using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed1 = 99.9f;
    // Update is called once per frame
    void Update()
    {
        //移动
        transform.position -= Vector3.forward * speed1 * Time.deltaTime;
        //超出摄像机位置后
        if (transform.position.z < -20)
        {
            //销毁自身
            Destroy(gameObject);
        }
    }
    //碰撞检测
    private void OnTriggerEnter(Collider other)
    {
        //如果碰到子弹
        if (other.tag == "Bullet")
        {
            //添加分数
            UIManager.Instance.Add();
            //销毁自身
            Destroy(gameObject);
        }
    }
}
