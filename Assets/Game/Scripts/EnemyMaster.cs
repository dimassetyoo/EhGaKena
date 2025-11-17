using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float SpawnInterval;
    public GameObject PrefabsObject;
    public bool IsSpawning=true;
    public float minX;
    public float maxX;
    public Transform SpawnPosition;
    public float StartDelay;


    void Start()
    {
        HitungBatasLayar();
        StartCoroutine(StartSpawn());
        //InvokeRepeating("SpawnEnemy", 1f, SpawnInterval);
    }

    void HitungBatasLayar()
    {
        Camera cam = Camera.main;
        float jarakZ = Mathf.Abs(cam.transform.position.z);

        Vector3 kiri = cam.ScreenToWorldPoint(new Vector3(0, 0, jarakZ));
        Vector3 kanan = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, jarakZ));

        minX = kiri.x;
        maxX = kanan.x;
    }

    void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, SpawnPosition.position.y, 0);

        int pilih = Random.Range(0, 5);
        Instantiate(PrefabsObject, spawnPos, Quaternion.identity);

            
    }

    IEnumerator SpawnObjectInterval()
    {
        while(IsSpawning)
        {
            yield return new WaitForSeconds (SpawnInterval);
            SpawnObject();
        }
        
    }

    IEnumerator StartSpawn()
    {
        yield return new WaitForSeconds (StartDelay);
        StartCoroutine (SpawnObjectInterval());
    }
}
