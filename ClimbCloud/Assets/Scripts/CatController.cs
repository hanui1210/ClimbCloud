
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float moveFoce;
    public float jumpFoce;
    public Animator animator;
    //private void start()
    //{
    // Rigidbody2D rb2D  = this.gameObject.GetComponent<Rigidbody2D>();
    //}
   
    void Start()
    {
        
    }


    void Update()
    {
        bool isLeftArrowHold = Input.GetKey(KeyCode.LeftArrow);
        bool isRighrArrowHold = Input.GetKey(KeyCode.RightArrow);




        if (isLeftArrowHold)
        {
            Debug.Log("왼쪽 키보드 입력");
            this.rb2D.AddForce(new Vector2(-1 * this.moveFoce, 0)); // 왼쪽이동
            this.transform.localScale = new Vector3(-1, 1, 1); // 왼쪽누를때 이미지 반전
            this.animator.SetInteger("state", 1);


        }
        else if (isRighrArrowHold)
        {
            Debug.Log("오른쪽 키보드 입력");
            this.rb2D.AddForce(new Vector2(1 * this.moveFoce, 0)); // 오른쪽이동
            this.transform.localScale = new Vector3(1, 1, 1); // 오른쪽누를때 이지미 반전
            this.animator.SetInteger("state", 1);
        }
        else
        {
            this.animator.SetInteger("state", 0);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // jump
            this.rb2D.AddForce(new Vector2(0, 1 * jumpFoce));
        }
    }
}
