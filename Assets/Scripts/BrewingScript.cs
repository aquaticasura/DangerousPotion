using UnityEngine;

public class BrewingScript : MonoBehaviour
{
    public CraftingLogic brewslot1, brewslot2, brewslot3;
    public int brewslotint1, brewslotint2, brewslotint3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        brewslotint1 = brewslot1.brewingitem;
        brewslotint2 = brewslot2.brewingitem;
        brewslotint3 = brewslot3.brewingitem;
    }

    public void brew()
    {
        //1 = scroom
        //2 = periahshroom
        //3 = dire flower
        //4 = crown flower
        //5 = moss plant
        //6 = creely
        //7 = trote
        //8 = desert mist

        int potion = brewslotint1 + brewslotint2 + brewslotint3;
        Debug.Log(potion);
    }
}
