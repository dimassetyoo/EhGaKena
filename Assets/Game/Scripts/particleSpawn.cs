using UnityEngine;

public class particleSpawn : MonoBehaviour
{
    public GameObject ObjectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 poisisiMos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(ObjectEffect, poisisiMos, Quaternion.identity);
        }
    }
}
