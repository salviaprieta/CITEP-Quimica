using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    UDictionary<string, bool> inventory = new UDictionary<string, bool>
        {
            { "carbono", false },
            { "azufre", false },
            { "cloro", false },
            { "oxigeno", false },
            { "nitrogeno", false },
            { "hidrogeno", false },
            { "fluor", false }
        };

    [SerializeField] GameObject hidrogenoUI;
    [SerializeField] GameObject carbonoUI;
    [SerializeField] GameObject nitrogenoUI;
    [SerializeField] GameObject oxigenoUI;
    [SerializeField] GameObject fluorUI;
    [SerializeField] GameObject cloroUI;
    [SerializeField] GameObject azufreUI;

    UDictionary<string, GameObject> elementsUI;

    private void Awake()
    {
        elementsUI = new UDictionary<string, GameObject>
        {
            { "carbono", carbonoUI },
            { "hidrogeno", hidrogenoUI },
            { "nitrogeno", nitrogenoUI },
            { "oxigeno", oxigenoUI },
            { "fluor", fluorUI },
            { "cloro", cloroUI },
            { "azufre", azufreUI },
        };
    }

    public void addElementToInventory(string element)
    {
        inventory[element] = true;
        elementsUI[element].SetActive(true);
    }
}
