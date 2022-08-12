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
        if (Input.GetMouseButton(0) && DataController.Instance.gameData.isMove==false) // Ŭ���� ���
        {
            xRotateMove = -Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed;
            yRotateMove = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;

            yRotate = transform.eulerAngles.y + yRotateMove;
            //xRotate = transform.eulerAngles.x + xRotateMove; 
            xRotate = xRotate + xRotateMove;

            xRotate = Mathf.Clamp(xRotate, -90, 90); // ��, �Ʒ� ����

            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);

            //RotateAround_LJY(target_LJY.position, DataController.Instance.gameData.cameraOffset, 20);
        }
    }
    /*
    // axis  : ȸ���� ����
    // diff  : (Ÿ���� ��ġ - �ڽ��� ��ġ) ����
    // speed : ȸ�� �ӵ�
    // t     : ���� ȸ������ ����� ����
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
