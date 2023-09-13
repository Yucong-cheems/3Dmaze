using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void EndingGame()
    {
   
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//如果是在unity编译器中
#else
        Application.Quit();//否则在打包文件中
#endif

    }
}

