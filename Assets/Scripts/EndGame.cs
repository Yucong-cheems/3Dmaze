using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void EndingGame()
    {
   
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�������unity��������
#else
        Application.Quit();//�����ڴ���ļ���
#endif

    }
}

