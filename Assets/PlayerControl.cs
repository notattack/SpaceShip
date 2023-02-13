using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //�����ӵ�Ԥ�Ƽ�
    public GameObject BulletPre;
    //�ӵ�����λ��
    private Transform firePoint;
    public float speed = 10.0f;
    void Start()
    {
        firePoint = transform.Find("FirePoint");
    }
    // Update is called once per frame
    void Update()
    {
        //�������
        //��ȡˮƽ����ֵ
        float horizontal = Input.GetAxis("Horizontal");
        //�����Ϊ0��֤�����ǰ��������ҷ����
        if(horizontal != 0)
        {
            //�ƶ�
            transform.position -= Vector3.left * speed * Time.deltaTime * horizontal;
            //����һ����Χ�����Ʒɻ���������Զ�ƶ�
            if (transform.position.x < -10 || transform.position.x > 10)
            {
                //������Χ��λ�ø�ԭ
                transform.position+=Vector3.left * speed * Time.deltaTime * horizontal;
            }
        }
        //�������
        //��ȡ��ֱ����ֵ
        float vertical = Input.GetAxis("Vertical");
        //�����Ϊ0��֤�����ǰ������ϻ��·����
        if(vertical != 0)
        {
            //�ƶ�
            transform.position+=Vector3.up * speed * Time.deltaTime * vertical;
            if (transform.position.y < -10 || transform.position.y > 10)
            {
                //�����ƶ���Χ
                transform.position-=Vector3.up * speed * Time.deltaTime * vertical;
            }
        }
        //���¿ո����ӵ�
      if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(BulletPre, firePoint.position, firePoint.rotation);
        }
    }
    
    //��ײ���
    private void OnCollisionEnter(Collision collision)
    {
        //��Ϸ����
        //Debug.Log("Game Over!");
        SceneManager.LoadScene("Over");
        //��Ϸʱ���0
        //Time.timeScale = 0;
    }
}
