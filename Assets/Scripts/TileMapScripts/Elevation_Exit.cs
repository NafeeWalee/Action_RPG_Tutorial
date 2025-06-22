using UnityEngine;

public class Elevation_Exit : MonoBehaviour
{
    public Collider2D[] MountainColliders;
    public Collider2D[] BoundaryColliders;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            foreach (Collider2D mountain in MountainColliders)
            {
                mountain.enabled = true;
            }
            foreach (Collider2D boundary in BoundaryColliders)
            {
                boundary.enabled = false;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
        }
    }
}
