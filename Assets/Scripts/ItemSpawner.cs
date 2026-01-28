using System.Collections;
using System.ComponentModel;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemtype;
    public GameObject itemholder;
    int haschildren;
    [SerializeField] float maxspawn, lowspawn, spawnrate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnrate = Random.Range(maxspawn, lowspawn);
        InvokeRepeating("itemspawner", spawnrate, spawnrate);

    }

    // Update is called once per frame
    void Update()
    {
        haschildren = itemholder.transform.childCount;
        Debug.Log(haschildren);


    }
    void itemspawner()
    {
        if ( haschildren == 0 )
        {
            Instantiate(itemtype, itemholder.transform);
            Debug.Log($"spawnrate: {spawnrate}");
        }

    }
}
