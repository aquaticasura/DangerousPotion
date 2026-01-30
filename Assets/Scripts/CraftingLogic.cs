using UnityEngine;

public class CraftingLogic : MonoBehaviour
{

    public Slot slot;
    public string crafting;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


         if (slot.currentItem != null)
        {
            Item slotItem = slot.currentItem.GetComponent<Item>();



            if (slotItem.Name != crafting)
            {
                if (slotItem.quantity > 1)
                {
                    //subract one from quantity on craft
                }
                crafting = slotItem.Name;
                Debug.Log(crafting);


            }
        }
        else
        {
            crafting = null;
            return;
        }
    }
}
