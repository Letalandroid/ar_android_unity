using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject itemsMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;

    void Start()
    {
        GameManager.instance.onMainMenu += ActivateMainMenu;
        GameManager.instance.onItemsMenu += ActivateItemsMenu;
        GameManager.instance.onARPosition += ActivateARPosition;
    }

    private void ActivateMainMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(.7f, 4, 1), .3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(.7f, 4, 1), .3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(.7f, 4, 1), .3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), .5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), .3f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180,.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), .3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), .3f);

    }

    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), .3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), .3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), .3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(.7f, 4, 1), .5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), .3f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, .3f);
    }

    private void ActivateARPosition()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), .3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), .3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), .3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), .5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), .3f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, .3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), .3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), .3f);
    }
}
