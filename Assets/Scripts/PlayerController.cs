using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;

    [Header("Shooting")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform firePoint1;
    [SerializeField] private Transform firePoint2;
    [SerializeField] private Transform firePoint3;
    public int bulletCount;
    public float fireRate = 0.5f;
    private float nextFireTime = 0f;
    private bool _fireSingle;

    [Header("Audio")]
    public AudioClip shootSound;
    public AudioClip CoinSound;
    private AudioSource audioSource;



    private Rigidbody2D rb;
    private Animator animator;
    private object context;
    private Vector2 moveInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();


        // Get or add AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Configure AudioSource for sound effects
        audioSource.playOnAwake = false;
        audioSource.volume = 0.7f; // Adjust volume as needed

    }

    private void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;
        HandleShooting();
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();


        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);

        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
        }
        else
        {
            animator.SetBool("isWalking", true);

            if (moveInput != Vector2.zero)
            {
                animator.SetFloat("LastInputX", moveInput.x);
                animator.SetFloat("LastInputY", moveInput.y);
            }
        }
    }

    private void HandleShooting()
    {

        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            FireBullet();
            nextFireTime = Time.time + fireRate;
            //_fireSingle = true;
        }

    }

    private void FireBullet()
    {
        if (GameManager.Instance.score > 400 && GameManager.Instance.score < 1000)
        {
            fireRate = 0.3f;
        }

        if (GameManager.Instance.score > 1500)
        {
            Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            Debug.Log("Extra Bullet");
        }

        if (GameManager.Instance.score > 4000)
        { 
            Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            Debug.Log("Extra Bullet");
        }

            if (GameManager.Instance.score > 8000)
        {
            Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
            Debug.Log("Extra Bullet");
        }

        if (bulletPrefab && firePoint)
            { Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
        // Play shoot sound effect
        audioSource.PlayOneShot(shootSound);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameManager.Instance.LoseLife();
            // Player hit by enemy - lose a life

        }

        if (other.CompareTag("Collectible"))
        {
            // Player collected an item
            Collectible collectible = other.GetComponent<Collectible>();
            if (collectible)
            {
                audioSource.PlayOneShot(CoinSound);
                Destroy(other.gameObject);
            }
        }
    }
}
