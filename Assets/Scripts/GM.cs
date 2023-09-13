using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public GameObject panel;            //此处panel是UI列表中的panel,需要挂上节点
   
    public void GameOver()
    {
        Time.timeScale = 0;                   //  暂停游戏
        panel.SetActive(true);                //panel显示，将游戏结束画面显示出来
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);        //加载初始场景

        Time.timeScale = 1;                        //游戏开始，不加上这句话即使游戏重新开始也是暂停状态
    }
}