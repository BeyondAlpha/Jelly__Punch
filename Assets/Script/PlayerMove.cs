using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    bool ableInput = false;
    bool ableStart = false;
    bool ableCheck = false;
    List<int> judgelist = new List<int>();
    List<string> hitEnemy = new List<string>();
    List<string> checklist = new List<string>();
    bool KeyGameStart = false;
    Vector3 hitEnemyTunacan;

    public float maxSpeed;
    public float jumpPower;
    static Rigidbody2D rigid;
    static SpriteRenderer spriteRenderer;
    Animator animator;
    BoxCollider2D boxcollider;
    static Transform transform;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        boxcollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        transform = GetComponent<Transform>();
    }
 
    void Update()
    {
        // Jump
        if (Input.GetButtonDown("Jump") && !animator.GetBool("isJumping")) {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
        }
            
        // Stop Speed
        if (Input.GetButtonUp("Horizontal")) {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }

        // Direction Sprite
        if (Input.GetButton("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;

        // Animation
        if (Mathf.Abs(rigid.velocity.x) < 0.3)
            animator.SetBool("isWalking", false);
        else
            animator.SetBool("isWalking", true);

        if (ableInput == true)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                checklist.Add("Left");
                GameObject.Find("LeftSound").GetComponent<AudioSource>().Play();
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                checklist.Add("Right");
                GameObject.Find("RightSound").GetComponent<AudioSource>().Play();
            }
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                checklist.Add("Up");
                GameObject.Find("UpSound").GetComponent<AudioSource>().Play();
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                checklist.Add("Down");
                GameObject.Find("DownSound").GetComponent<AudioSource>().Play();
            }
        } 
        
        if (checklist.Count == hitEnemy.Count)
        {
            for (int i = 0; i < hitEnemy.Count; i++)
            {
                if (checklist[i].Equals(hitEnemy[i]))
                {
                    //1개라도 같지 않은 요소가 있으면 false
                    judgelist.Add(1);
                }
                else
                {
                    judgelist.Add(0);
                }
            }
        }

        
        if ( ableInput == true && judgelist.Count == hitEnemy.Count)
        {
            if (!judgelist.Contains(0))
            {
                ableCheck = true;
                judgelist = new List<int>();
                checklist = new List<string>();
                ableInput = false;
            }
            else
            {
                GameManager.HealthDown();
                judgelist = new List<int>();
                checklist = new List<string>();
                ableInput = false;
            }
            
        }

        if (ableCheck == true)
        {
            Instantiate(GameObject.Find("Tunacan_item"), hitEnemyTunacan, Quaternion.identity);
            ableCheck = false;
        }
        
    }

    void FixedUpdate()
    {
        int _End = 1<<LayerMask.NameToLayer("End");
        RaycastHit2D EndingRay = Physics2D.Raycast(transform.position, new Vector3(0.1f,0,0), 1, _End);
        if (EndingRay.collider != null )
        {
            SceneManager.LoadScene("win");
        }

        int _Ground = 1<<LayerMask.NameToLayer("Ground");
        // Move Speed
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h * 2, ForceMode2D.Impulse);
        
        // Max Speed
        if (rigid.velocity.x > maxSpeed) //Right Max Speed
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y); 
        else if (rigid.velocity.x < maxSpeed * (-1)) //Left Max Speed
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y); 

        // Landing Platform
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0,1,0));
        RaycastHit2D rayHit = Physics2D.Raycast(transform.position, new Vector3(0,-0.5f,0), 1, _Ground);
        
        if(rigid.velocity.y <= 0 && animator.GetBool("isJumping") == true) {
            Debug.Log(rayHit.collider.name);
            if(rayHit.collider != null) {
                animator.SetBool("isJumping", false);
            }
        }
    }

    void OnAttack(Transform enemy)
    {
        // Enemy Die
        EnemyMove enemyMove = enemy.GetComponent<EnemyMove>();
        enemyMove.OnDamaged();

        // Tunacan appear

    }

    void OnDamaged(Vector2 targetPos)
    {
        // Health Down
        GameManager.HealthDown();

        // Change Layer (Immortal Active)
        gameObject.layer = 11;

        // Become Transparent
        spriteRenderer.color = new Color(1,1,1,0.4f);

        // Reaction Force
        int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;
        rigid.AddForce(new Vector2(dirc, 1)*7, ForceMode2D.Impulse);

        // Back to Original
        Invoke("OffDamaged", 1);

        // Player Reposition
        transform.position = new Vector3(0, 0, 0);
    }

    void OffDamaged()
    {
        gameObject.layer = 10;
        spriteRenderer.color = new Color(1, 1, 1, 1);
    }

    static public void OnDie()
    {
        // Sprite Alpha
        spriteRenderer.color = new Color(1, 1, 1, 0.4f);

        // Sprite Flip Y
        spriteRenderer.flipY = true;

        // Die Effect Jump
        rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

        // Player Reposition
        transform.position = new Vector3(0, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item") {
            // Point
            GameManager.stagePoint += 1;

            // Deactive Item
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Finish") {
            // Next Stage
            SceneManager.LoadScene("Stage_scene");
        }
        if (collision.gameObject.name == "water")
        {
            SceneManager.LoadScene("fail");

            // Player Reposition
            transform.position = new Vector3(0, 0, 0);            
        }

        if(collision.gameObject.tag == "Enemy") {
            hitEnemy = GameObject.Find(collision.name).GetComponent<Enemy>().notes;
            hitEnemyTunacan = GameObject.Find(collision.name).GetComponent<Enemy>().tunacan;
            StartCoroutine(KeyGame.PrintSound(hitEnemy));
        }
    }
}
