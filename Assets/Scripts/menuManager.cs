using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryUI;
    [SerializeField] GameObject scanCameraAssets;
    [SerializeField] GameObject scanCameraUI;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject challengeUI;
    [SerializeField] GameObject mainMenu;

    public void goToInventory()
    {
        scanCameraAssets.SetActive(false);
        scanCameraUI.SetActive(false);
        challengeUI.SetActive(false);
        mainCamera.SetActive(true);
        inventoryUI.SetActive(true);
    }

    public void goToScanCamera()
    {
        inventoryUI.SetActive(false);
        mainCamera.SetActive(false);
        challengeUI.SetActive(false);
        scanCameraAssets.SetActive(true);
        scanCameraUI.SetActive(true);
    }

    public void goToChallenge()
    {
        mainMenu.SetActive(false);
        scanCameraAssets.SetActive(false);
        scanCameraUI.SetActive(false);
        inventoryUI.SetActive(false);
        mainCamera.SetActive(true);
        challengeUI.SetActive(true);
    }
}
