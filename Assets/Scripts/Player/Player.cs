using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    private Rigidbody2D myrigidbody;
    [SerializeField]
    private float movementspeed = 10f;
    [SerializeField]
    private float jumpheigt = 10f;
    private bool isGround;
    private bool facing = true;
    private float horizontal;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public GameObject PanelLose, RestartButton, Blood;
    public GameObject PanelWin;

    public AudioSource sound;
    public AudioSource jumpSound;

    void Start()
    {

        RestartButton.SetActive(false);
        myrigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsGround);
        myrigidbody.velocity = new Vector2(horizontal * movementspeed, myrigidbody.velocity.y);
        if (CrossPlatformInputManager.GetButtonDown("Jump") && isGround == true)
        {
            myrigidbody.AddForce(transform.up * jumpheigt, ForceMode2D.Impulse);
            jumpSound.Play();
        }
        if (horizontal > 0 && !facing)
        {
            Flip();
        }
        else if (horizontal < 0 && facing)
        {
            Flip();
        }
    }
    private void Flip()
    {
        facing = !facing;
        transform.Rotate(0f, 180f, 0f);
    }
    void Lose()
    {
        myrigidbody.bodyType = RigidbodyType2D.Static;
        PanelLose.SetActive(true);
        Destroy(gameObject);
    }
    void Finish()
    {
        myrigidbody.bodyType = RigidbodyType2D.Static;
        PanelWin.SetActive(true);
        Destroy(gameObject);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            RestartButton.SetActive(true);
            Instantiate(Blood, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            sound.Play();
        }
    }
}
