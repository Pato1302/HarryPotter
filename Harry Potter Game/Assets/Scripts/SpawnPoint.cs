using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        int character = PlayerPrefs.GetInt("Character");
        if (character == 1)
        {
            Instantiate(prefab1, transform.position, transform.rotation);
        }
        if (character == 2)
        {
            Instantiate(prefab2, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
