using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject platformDestroy;

    // Start is called before the first frame update
    void Start()
    {
        platformDestroy = GameObject.Find("PlatformDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < platformDestroy.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
