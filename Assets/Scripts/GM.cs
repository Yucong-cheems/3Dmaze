using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public GameObject panel;            //�˴�panel��UI�б��е�panel,��Ҫ���Ͻڵ�
   
    public void GameOver()
    {
        Time.timeScale = 0;                   //  ��ͣ��Ϸ
        panel.SetActive(true);                //panel��ʾ������Ϸ����������ʾ����
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);        //���س�ʼ����

        Time.timeScale = 1;                        //��Ϸ��ʼ����������仰��ʹ��Ϸ���¿�ʼҲ����ͣ״̬
    }
}