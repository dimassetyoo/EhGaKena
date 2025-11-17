using UnityEngine;

public class EnemyB : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool sudahMenyentuhLantai = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // memberi dorongan awal ke kanan/kiri secara random
        float arahX = Random.Range(-1f, 1f) < 0 ? -1f : 1f;
        float kekuatan = Random.Range(3f, 6f);

        rb.AddForce(new Vector2(arahX * kekuatan, 0), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // ✔ Jika mengenai pemain → langsung hancur
        if (col.collider.CompareTag("Player"))
        {
            col.gameObject.GetComponent<objPemain>().KurangNyawa();
            Destroy(gameObject);
            //return;
        }

        // ✔ Jika menyentuh lantai → mulai timer 3 detik
        if (col.collider.CompareTag("Lantai") && !sudahMenyentuhLantai)
        {
            sudahMenyentuhLantai = true;
            Invoke("DestroyEnemy", 5f);
        }
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
