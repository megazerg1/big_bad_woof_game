using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;
    public float jumpForce = 400;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isJumping;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        float xDisplacement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        animator.SetFloat("speed", rb.velocity.x);
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1.6f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1.6f;
        }
        transform.localScale = characterScale;



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
            animator.SetTrigger("takeOf");
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", true);

        }

        {
            float speed = 2;
            if (Input.GetKey(KeyCode.LeftShift)) speed = 8;
            var y = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

            transform.Translate(y, 0, 0);
            transform.Translate(0, 0, z);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetTrigger("playerattack");
        }

    }
  


        void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("movingPlatform"))
            this.transform.parent = col.transform;
        isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("movingPlatform"))
            this.transform.parent = null;
        isGrounded = true;
    }

}
