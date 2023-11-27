using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    public Element[] inventory;

    [SerializeField]
    private GameObject hidrogenoBlocker;

    [SerializeField]
    private GameObject carbonoBlocker;

    [SerializeField]
    private GameObject nitrogenoBlocker;

    [SerializeField]
    private GameObject oxigenoBlocker;

    [SerializeField]
    private GameObject fluorBlocker;

    [SerializeField]
    private GameObject cloroBlocker;

    [SerializeField]
    private GameObject azufreBlocker;

    [SerializeField]
    private Sprite hidrogenoSprite;

    [SerializeField]
    private Sprite carbonoSprite;

    [SerializeField]
    private Sprite nitrogenoSprite;

    [SerializeField]
    private Sprite oxigenoSprite;

    [SerializeField]
    private Sprite fluorSprite;

    [SerializeField]
    private Sprite cloroSprite;

    [SerializeField]
    private Sprite azufreSprite;

    private void Awake()
    {
        inventory = new Element[7];
        inventory[0] = new Element("carbono", "Carbono", "C", false, carbonoBlocker, carbonoSprite);

        inventory[1] = new Element("azufre", "Azufre", "S", false, azufreBlocker, azufreSprite);

        inventory[2] = new Element("cloro", "Cloro", "Cl", false, cloroBlocker, cloroSprite);

        inventory[3] = new Element("oxigeno", "Oxigeno", "O", false, oxigenoBlocker, oxigenoSprite);

        inventory[4] = new Element(
            "nitrogeno",
            "Nitrogeno",
            "N",
            false,
            nitrogenoBlocker,
            nitrogenoSprite
        );

        inventory[5] = new Element(
            "hidrogeno",
            "Hidrogeno",
            "H",
            false,
            hidrogenoBlocker,
            hidrogenoSprite
        );

        inventory[6] = new Element("fluor", "Fluor", "F", false, fluorBlocker, fluorSprite);
    }

    public void addElementToInventory(string element)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i].slug == element)
            {
                inventory[i].inInventory = true;
                inventory[i].blockerUI.SetActive(false);
            }
        }
    }

    public List<string> getUnlockedElements()
    {
        List<string> unlockedElements = new List<string>();

        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i].inInventory)
                unlockedElements.Add(inventory[i].symbol);
        }

        return unlockedElements;
    }

    public Element getElementBySlug(string slug)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i].slug == slug)
                return inventory[i];
        }
        return null;
    }

    public bool isInInventory(string slug)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i].slug == slug && inventory[i].inInventory)
                return true;
        }
        return false;
    }

    public Element getElementBySymbol(string symbol)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i].symbol == symbol)
                return inventory[i];
        }
        return null;
    }
}

[System.Serializable]
public class Element
{
    public string slug;
    public string name;
    public string symbol;
    public bool inInventory;
    public GameObject blockerUI;
    public Sprite sprite;

    public Element(
        string slug,
        string name,
        string symbol,
        bool inInventory,
        GameObject blockerUI,
        Sprite sprite
    )
    {
        this.slug = slug;
        this.name = name;
        this.symbol = symbol;
        this.inInventory = inInventory;
        this.blockerUI = blockerUI;
        this.sprite = sprite;
    }
}
