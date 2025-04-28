using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {

    }
    public void jump0()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        // 在Unity编辑器里退出是无效的，只能打包后才真正退出
        Application.Quit();
        Debug.Log("退出游戏"); // 方便在编辑器里测试
    }
}


