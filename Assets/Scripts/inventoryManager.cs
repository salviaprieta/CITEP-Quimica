using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryManager : MonoBehaviour
{
    [SerializeField]
    UDictionary<string, bool> inventory = new UDictionary<string, bool>
        {
            { "carbono", false },
            { "sodio", false },
            { "cloro", false },
            { "oxigeno", false },
            { "nitrogeno", false },
            { "hidrogeno", false },
            { "fluor", false }
        };

    [SerializeField] GameObject hidrogenoUI;
    [SerializeField] GameObject carbonoUI;

    UDictionary<string, GameObject> elementsUI;

    private void Awake()
    {
        elementsUI = new UDictionary<string, GameObject>
        {
            { "carbono", carbonoUI },
            { "hidrogeno", hidrogenoUI },
        };
    }

    public void addElementToInventory(string element)
    {
        inventory[element] = true;
        elementsUI[element].SetActive(true);
    }
}
