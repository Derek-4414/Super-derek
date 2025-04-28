using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Button showButton, CloseButton;
    public GameObject tipInfo;
    public bool isShow = true, isTipInfoShow = false;

    void Start()
    {
        showButton.onClick.AddListener(() =>
        {
            tipInfo.SetActive(true);
        });

        CloseButton.onClick.AddListener(() =>
        {
            tipInfo.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        tipInfo.SetActive(true);
    }
    private void OnMouseExit()
    {
        tipInfo.SetActive(false);
    }
}
