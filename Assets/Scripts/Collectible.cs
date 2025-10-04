using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Header("Collectible Settings")]
    public int value = 25;
    public float rotationSpeed = 0f;

    private void Update()
    {
        // Rotate for visual effect
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Easy access to GameManager through Singleton!
            GameManager.Instance.CollectiblePickedUp(value);
            Destroy(gameObject);
        }
    }
}