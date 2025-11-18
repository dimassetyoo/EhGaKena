using UnityEngine;

public class ObjHealth : MonoBehaviour
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
            col.gameObject.GetComponent<objPemain>().tambahNyawa();
            Debug.Log("namnbah nyawa");
        }
        Destroy(gameObject);
    }

}
