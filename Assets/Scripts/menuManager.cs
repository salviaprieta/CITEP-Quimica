using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryUI;
    [SerializeField] GameObject scanCameraAssets;
    [SerializeField] GameObject scanCameraUI;
    [SerializeField] GameObject mainCamera;

    public void goToInventory()
    {
        scanCameraAssets.SetActive(false);
        scanCameraUI.SetActive(false);
        mainCamera.SetActive(true);
        inventoryUI.SetActive(true);
    }

    public void goToScanCamera()
    {
        inventoryUI.SetActive(false);
        scanCameraAssets.SetActive(true);
        mainCamera.SetActive(false);
        scanCameraUI.SetActive(true);
    }
}
