using UnityEngine;

public class EnemyA : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        // ❌ Tidak hancur bila menyentuh pemain
        if (col.collider.CompareTag("Player"))
        {
            col.gameObject.GetComponent<objPemain>().KurangNyawa();
        }

        // ❌ Tidak hancur bila menyentuh objek lain selain lantai
        if (!col.collider.CompareTag("Lantai"))
        {
            
        }

        // ✅ HANCUR hanya ketika menyentuh lantai
                Destroy(gameObject);

    }
}
