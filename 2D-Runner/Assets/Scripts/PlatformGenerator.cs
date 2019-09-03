using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceMin;
    public float distanceMax;


    public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightChange;
    private float heightChange;

    // Start is called before the first frame update
    void Start()
    {
        platformWidths = new float[thePlatforms.Length];

        for (int i = 0; i < thePlatforms.Length; i++)
        {
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;

        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceMin, distanceMax);

            platformSelector = Random.Range(0, thePlatforms.Length);

            heightChange = transform.position.y + Random.Range(maxHeightChange, - maxHeightChange);

            if (heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }
            else if (heightChange < minHeight)
            {
                heightChange = minHeight;
            }

            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distanceBetween, heightChange, transform.position.z);

            Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);
        }
    }
}
