using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //关联子弹预制件
    public GameObject BulletPre;
    //子弹发射位置
    private Transform firePoint;
    public float speed = 10.0f;
    void Start()
    {
        firePoint = transform.Find("FirePoint");
    }
    // Update is called once per frame
    void Update()
    {
        //横向飞行
        //获取水平轴数值
        float horizontal = Input.GetAxis("Horizontal");
        //如果不为0，证明我们按下了左右方向键
        if(horizontal != 0)
        {
            //移动
            transform.position -= Vector3.left * speed * Time.deltaTime * horizontal;
            //设置一个范围，限制飞机不能无限远移动
            if (transform.position.x < -10 || transform.position.x > 10)
            {
                //超出范围，位置复原
                transform.position+=Vector3.left * speed * Time.deltaTime * horizontal;
            }
        }
        //纵向飞行
        //获取垂直轴数值
        float vertical = Input.GetAxis("Vertical");
        //如果不为0，证明我们按下了上或下方向键
        if(vertical != 0)
        {
            //移动
            transform.position+=Vector3.up * speed * Time.deltaTime * vertical;
            if (transform.position.y < -10 || transform.position.y > 10)
            {
                //设置移动范围
                transform.position-=Vector3.up * speed * Time.deltaTime * vertical;
            }
        }
        //按下空格发射子弹
      if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(BulletPre, firePoint.position, firePoint.rotation);
        }
    }
    
    //碰撞检测
    private void OnCollisionEnter(Collision collision)
    {
        //游戏结束
        //Debug.Log("Game Over!");
        SceneManager.LoadScene("Over");
        //游戏时间归0
        //Time.timeScale = 0;
    }
}
