using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action onMainMenu;
    public event Action onItemsMenu;
    public event Action onARPosition;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }
    }

    void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        onMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");
    }

    public void ItemsMenu() {
        onItemsMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }

    public void ARPositionMenu() {
        onARPosition?.Invoke();
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
