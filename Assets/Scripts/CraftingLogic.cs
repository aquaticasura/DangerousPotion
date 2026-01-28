using UnityEngine;

public class CraftingLogic : MonoBehaviour
{

    public Slot slot;
    public string crafting;
    private string replace = "(Clone) (UnityEngine.GameObject)";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (slot.currentItem != null)
        {
            if (slot.currentItem.ToString() != crafting)
            {
                crafting = slot.currentItem.ToString();
                string result = crafting.Replace(replace, "");
                Debug.Log(result);

            }
        }
        else
        {
            crafting = null;
            return;
        }
    }
}
