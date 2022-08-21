using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove_LJY : MonoBehaviour
{
    private float xRotate, yRotate, xRotateMove, yRotateMove;
    public float rotateSpeed = 500.0f;

    public Transform target_LJY;

    void Update()
    {
        if (Input.GetMouseButton(0) && DataController.Instance.gameData.isMove==false) // 클릭한 경우
        {
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
