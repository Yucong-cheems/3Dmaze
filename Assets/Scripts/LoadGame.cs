using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public void LoadingGame()//���ӵ���Ϸ����1
    {
        SceneManager.LoadScene(1);
    }
    public void LoadingBegin()//���ӵ���ʼ����0
    {
        SceneManager.LoadScene(0);
    }
}

