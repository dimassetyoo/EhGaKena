using TMPro;
using UnityEngine;

public class DummyInput : MonoBehaviour
{
   public TMP_Text Health;
   public TMP_Text Score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bolaPrefab;
    public GameObject bolaPrefab1;
    public float interval = 2f;

    public float minX = -5f;  // batas kiri
    public float maxX = 5f;   // batas kanan
    public string targetTag = "Hancurkan";
    void Start()
    {
        InvokeRepeating("SpawnBall", 0f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("nyawa tambah 1");
        }
        if(Input.GetMouseButton(1))
        {
            Debug.Log("Nyawa kurang 1");
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("tambah skor 1");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
        }
    }
    void SpawnBall()
    {
    // X random, Y tetap dari atas
    float randomX = Random.Range(minX, maxX);

    Vector3 spawnPos = new Vector3(
        randomX,
        transform.position.y,   // Y tetap
        transform.position.z
    );

    // munculkan bola
    Instantiate(bolaPrefab, spawnPos, Quaternion.identity);
    Instantiate(bolaPrefab1, spawnPos, Quaternion.identity);
    }

}
