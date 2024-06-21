using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RibbitPlayer : MonoBehaviour
{
    Camera mainCamera;
    public CheckGround checkGround;
    public GameObject particles;
    public float speed = 3f;
    public float jumpSpeed = 5f;
    //public bool isGrounded = false;
    private Rigidbody2D rbRibbit;
    private Animator animRibbit;
    private SpriteRenderer srRibbit;
    private bool isJumping = false;
    public static bool isDie = false;//static para calcular puntaje
    public static bool isWin = false;//static para calcular puntaje
    void Awake()
    {
        rbRibbit = GetComponent<Rigidbody2D>();
        animRibbit = GetComponent<Animator>();
        srRibbit = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;
    }
    private void Start()
    {
        isDie = false;
        isWin = false;
    }
    private void GameLose()
    {
        GameManager.Instance.ShowGameOverScreen();
        Time.timeScale = 0f;
    }
    private void EffectLose()
    {
        srRibbit.enabled = false;
        particles.SetActive(true);
    }
    private void GameWin()
    {
        isWin = true;
        Time.timeScale = 0f;
        //GameManager.Instance.UpdateTotalScore();
        GameManager.Instance.ShowGameWinnerScreen();
    }
    private void LoadNewLevel()
    {
        isWin = true;
        //GameManager.Instance.UpdateTotalScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (checkGround.isGrounded)
        {
            animRibbit.SetBool("IsGrounded", checkGround.isGrounded);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isDie = true;
            animRibbit.SetTrigger("Die");
            Invoke("EffectLose", 0.2f);
            Invoke("GameLose", 1.25f);
        }
        else if (collision.gameObject.CompareTag("Objective"))
        {
            LoadNewLevel();
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            GameWin();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!checkGround.isGrounded)
        {
            animRibbit.SetBool("IsGrounded", checkGround.isGrounded);
        }
    }
    private void Update()
    {
        //PC
        if (Input.GetKeyDown(KeyCode.Space) && checkGround.isGrounded)
        {
            isJumping = true;
        }
        //Android
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began && checkGround.isGrounded)
            {
                isJumping = true;
            }
        }
        if (transform.position.x >= mainCamera.transform.position.x)
        {
            mainCamera.transform.position = new Vector3(transform.position.x,
                mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
    }
    private void FixedUpdate()
    {
        if (!isDie || !isWin)
        {
            rbRibbit.velocity = new Vector2(speed, rbRibbit.velocity.y);
            if (isJumping)
            {
                isJumping = false;
                rbRibbit.velocity = new Vector2(rbRibbit.velocity.x, jumpSpeed);
            }
        }
    }
}