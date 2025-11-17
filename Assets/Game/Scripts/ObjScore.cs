using UnityEngine;

public class ObjScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            col.gameObject.GetComponent<objPemain>().TambahSkor();
            Debug.Log("namnbah skor");
        }
        Destroy(gameObject);
    }
}
