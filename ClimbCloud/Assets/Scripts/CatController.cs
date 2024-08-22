
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
            Debug.Log("���� Ű���� �Է�");
            this.rb2D.AddForce(new Vector2(-1 * this.moveFoce, 0)); // �����̵�
            this.transform.localScale = new Vector3(-1, 1, 1); // ���ʴ����� �̹��� ����
            this.animator.SetInteger("state", 1);


        }
        else if (isRighrArrowHold)
        {
            Debug.Log("������ Ű���� �Է�");
            this.rb2D.AddForce(new Vector2(1 * this.moveFoce, 0)); // �������̵�
            this.transform.localScale = new Vector3(1, 1, 1); // �����ʴ����� ������ ����
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
