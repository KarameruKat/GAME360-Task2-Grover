using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Stats")]
    public int health = 1;
    public float moveSpeed = 2f;

    [Header("AI")]
    public float detectionRange = 5f;

    private Transform player;
    private Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private EnemyState currentState;

    private void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody2D>();
        if (animator == null) animator = GetComponent<Animator>();
        if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer>();

        //ChangeState(new WaspFly);

        // Find player
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj) player = playerObj.transform;
    }

    private void Update()
    {
        ChasePlayer();
    }

    private void ChasePlayer()
    {
        if (player)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance <= detectionRange)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                rb.linearVelocity = direction * moveSpeed;
            }
            else
            {
                rb.linearVelocity = Vector3.zero;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // This is where Singleton shines!
        // Any enemy can easily notify the GameManager
        GameManager.Instance.EnemyKilled();
        Destroy(gameObject);
    }

    
}