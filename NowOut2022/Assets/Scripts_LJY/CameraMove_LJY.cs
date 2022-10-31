using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMove_LJY : MonoBehaviour
{
    private float xRotate, yRotate, xRotateMove, yRotateMove;
    public float rotateSpeed = 500.0f;

    public Transform target_LJY;

    public GameObject DataController;
    public int pointerId=0;

//    private void Awake()
//    {
////#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
////        pointerId = -1;
////#elif UNITY_ANDROID ||UNITY_IOS || UNITY_WP8 || UNITY_IPHONE
////pointerId = 0;
////#endif
//    }

    void Update()
    {
        DataController.GetComponent<DataController>().SaveGameData();
        if (Input.GetMouseButton(0) && DataController.GetComponent<DataController>().gameData.isMove == false) // 클릭한 경우
        {
            if (!EventSystem.current.IsPointerOverGameObject(pointerId))
            {

                //클릭 처리
                xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
                yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

                yRotate = transform.eulerAngles.y + yRotateMove;
                //xRotate = transform.eulerAngles.x + xRotateMove; 
                xRotate = xRotate + xRotateMove;

                xRotate = Mathf.Clamp(xRotate, -90, 90); // 위, 아래 고정

                transform.eulerAngles = new Vector3(xRotate, yRotate, 0);

                //RotateAround_LJY(target_LJY.position, DataController.Instance.gameData.cameraOffset, 20);
            }

        }
    }
    /*
    // axis  : 회전축 벡터
    // diff  : (타겟의 위치 - 자신의 위치) 벡터
    // speed : 회전 속도
    // t     : 현재 회전값을 기억할 변수
    private void RotateAround_LJY(in Vector3 axis, in Vector3 diff, float speed)
    {
        float t = speed * Time.deltaTime;

        Vector3 offset = Quaternion.AngleAxis(t, Vector3.up) * diff;
        transform.position = target_LJY.position + offset;

        Quaternion rot = Quaternion.LookRotation(-offset, axis);
        transform.rotation = rot;
    }
    */
}
