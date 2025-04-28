using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject contorller;  // 物体A的引用
    public float moveSpeed = 0.5f;  // 物体B的前进速度

    private Vector3 previousPosition = new Vector3();  // 记录物体A的上一帧位置

    void Start()
    {
        // 初始化物体A的初始位置
        if (contorller != null)
        {
            previousPosition = contorller.transform.position;
        }
    }

    void Update()
    {
        if (contorller != null)
        {
            // 计算物体A移动的距离
            float distanceMoved = Vector3.Distance(previousPosition, contorller.transform.position);

            // 根据物体A的移动距离来控制物体B的前进
            transform.Translate(distanceMoved * moveSpeed * new Vector3(Mathf.Sin(transform.localEulerAngles.y * Mathf.Deg2Rad),0,Mathf.Cos(transform.localEulerAngles.y*Mathf.Deg2Rad)), Space.World);

            // 更新物体A的上一帧位置
            previousPosition = contorller.transform.position;
        }
    }
}
