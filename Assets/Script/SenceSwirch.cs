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
        // ��Unity�༭�����˳�����Ч�ģ�ֻ�ܴ����������˳�
        Application.Quit();
        Debug.Log("�˳���Ϸ"); // �����ڱ༭�������
    }
}


