using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBackPack : MonoBehaviour
{
    public int maxNumberFruitsToStore = 50;
    public int currentNumberofStoredFruits;

    [SerializeField]
    private Text backpackInfoTxt;


    private void Start()
    {
        SetBackpackInfoText(0);
    }

    public void AddFruits(int amount)
    {
        currentNumberofStoredFruits += amount;

        if (currentNumberofStoredFruits > maxNumberFruitsToStore)
            currentNumberofStoredFruits = maxNumberFruitsToStore;

        SetBackpackInfoText(currentNumberofStoredFruits);

    }

    public int TakeFruits()
    {
        int takenFruits = currentNumberofStoredFruits;

        currentNumberofStoredFruits = 0;

        SetBackpackInfoText(currentNumberofStoredFruits);

        return takenFruits;


    }

    void SetBackpackInfoText(int amount)
    {
        backpackInfoTxt.text = "Backpack: " + amount + "/" + maxNumberFruitsToStore;

    }


}
