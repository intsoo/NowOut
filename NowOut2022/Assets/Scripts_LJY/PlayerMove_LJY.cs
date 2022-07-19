using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_LJY : MonoBehaviour
{
    public float speed_LJY;
    //float hAxis_LJY;
    //float vAxis_LJY;
    //bool wDown_LJY;

    public VariableJoystick joy_LJY;

    Vector3 moveVec_LJY;

    Rigidbody rigid_LJY;
    Animator PlayerAnim_LJY;

    void Awake()
    {
        rigid_LJY = GetComponent<Rigidbody>();
        PlayerAnim_LJY = GetComponentInChildren<Animator>(); 
    }

    void FixedUpdate()
    {
        // 1. Input Value
        float x = joy_LJY.Horizontal;
        float z = joy_LJY.Vertical;

        // 2. Move Position
        moveVec_LJY = new Vector3(x, 0, z) * speed_LJY * Time.fixedDeltaTime;
        rigid_LJY.MovePosition(rigid_LJY.position + moveVec_LJY);

        if (moveVec_LJY.sqrMagnitude == 0)
            return; //No input = No rotation

        // 3. Move Rotation
        transform.LookAt(transform.position + moveVec_LJY);

        //Quaternion dirQuat_LJY = Quaternion.LookRotation(moveVec_LJY);
        //Quaternion moveQuat_LJY = Quaternion.Slerp(rigid_LJY.rotation, dirQuat_LJY, 0.3f);
    }

    void LateUpdate()
    {
        PlayerAnim_LJY.SetBool("isRun", moveVec_LJY != Vector3.zero);
        //PlayerAnim_LJY.SetFloat("Move", moveVec_LJY.sqrMagnitude);
    }
    /*
    void Update()
    {
        //hAxis_LJY = Input.GetAxisRaw("Horizontal");
        //vAxis_LJY = Input.GetAxisRaw("Vertical");
        //wDown_LJY = Input.GetButton("Walk");

        moveVec_LJY = new Vector3(hAxis_LJY, 0, vAxis_LJY).normalized;

        transform.position += moveVec_LJY * speed_LJY * (wDown_LJY ? 0.3f : 1f) * Time.deltaTime;

        PlayerAnim_LJY.SetBool("isRun", moveVec_LJY != Vector3.zero);
        PlayerAnim_LJY.SetBool("isWalk", wDown_LJY);

        transform.LookAt(transform.position + moveVec_LJY);
    }
    */
}
