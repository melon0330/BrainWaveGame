using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
<<<<<<< HEAD
    public float maxSpeed;
    Rigidbody2D rigid;
    public bool isTouchBottom;
    SpriteRenderer spriteRenderer;

    private void Awake() {

        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
       }
        if (Input.GetButtonDown("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (isTouchBottom && h == 1)
            h = 0;

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed*(-1))
            rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Bottom":
                    isTouchBottom = true;
                    break;

            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Bottom":
                    isTouchBottom = false;
                    break;

            }
        }
=======
    Rigidbody2D rigid; //물리이동을 위한 변수 선언 

    private void Awake() {
        
        rigid = GetComponent<Rigidbody2D>(); //변수 초기화 

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");   
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

>>>>>>> 5abf8fa6c77ac1de9b9fff30e710b57de91c6756
    }
}