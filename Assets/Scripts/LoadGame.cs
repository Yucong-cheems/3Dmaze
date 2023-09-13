using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public void LoadingGame()//连接到游戏场景1
    {
        SceneManager.LoadScene(1);
    }
    public void LoadingBegin()//连接到开始场景0
    {
        SceneManager.LoadScene(0);
    }
}

