using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject contorller;  // ����A������
    public float moveSpeed = 0.5f;  // ����B��ǰ���ٶ�

    private Vector3 previousPosition = new Vector3();  // ��¼����A����һ֡λ��

    void Start()
    {
        // ��ʼ������A�ĳ�ʼλ��
        if (contorller != null)
        {
            previousPosition = contorller.transform.position;
        }
    }

    void Update()
    {
        if (contorller != null)
        {
            // ��������A�ƶ��ľ���
            float distanceMoved = Vector3.Distance(previousPosition, contorller.transform.position);

            // ��������A���ƶ���������������B��ǰ��
            transform.Translate(distanceMoved * moveSpeed * new Vector3(Mathf.Sin(transform.localEulerAngles.y * Mathf.Deg2Rad),0,Mathf.Cos(transform.localEulerAngles.y*Mathf.Deg2Rad)), Space.World);

            // ��������A����һ֡λ��
            previousPosition = contorller.transform.position;
        }
    }
}
