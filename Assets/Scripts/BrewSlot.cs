using UnityEditor;
using UnityEngine;

public class BrewSlot : MonoBehaviour
{
    public GameObject HealthPotion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject CloneItem()
    {
        GameObject clone = Instantiate(gameObject);
        Item cloneItem = HealthPotion.GetComponent<Item>();
        cloneItem.UpdateQuantityDisplay();
        return clone;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
