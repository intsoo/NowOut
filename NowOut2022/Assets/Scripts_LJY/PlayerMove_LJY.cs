using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_LJY : MonoBehaviour
{
    public float speed_LJY;
    public float jumpHeight_LJY;
    bool isJump_LJY;

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
        DataController.Instance.gameData.isMove = true;

        if(moveVec_LJY == Vector3.zero)
            DataController.Instance.gameData.isMove = false;

        if (moveVec_LJY.sqrMagnitude == 0)
            return; //No input = No rotation

        // 3. Move Rotation
        transform.LookAt(transform.position + moveVec_LJY);
    }

    void LateUpdate()
    {
        PlayerAnim_LJY.SetBool("isRun", moveVec_LJY != Vector3.zero);
    }

    //점프를 트리거 하는 함수
    public void Jump_LJY()
    {
        if (!isJump_LJY)
        {
            PlayerAnim_LJY.SetBool("isJump", true);
            PlayerAnim_LJY.SetTrigger("doJump");
            StartCoroutine(JumpDelay_LJY());
        }
    }

    //점프 뛰는 모션 때문에 딜레이 거친 후 이 함수에서 실제 점프 실행
    IEnumerator JumpDelay_LJY()
    {
        yield return new WaitForSeconds(0.5f);

        rigid_LJY.AddForce(Vector3.up * jumpHeight_LJY, ForceMode.Impulse);
        isJump_LJY = true;
        DataController.Instance.gameData.jump++;
    }

    void OnCollisionEnter(Collision collision)
    {
        /*
        if(collision.gameObject.tag == "Floor")
        {
            PlayerAnim_LJY.SetBool("isJump", false);
            isJump_LJY = false; 
        }
        */
        PlayerAnim_LJY.SetBool("isJump", false);
        isJump_LJY = false;
    }

}
