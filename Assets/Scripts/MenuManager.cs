using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField] Button _spinButton;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _spinButton.onClick.AddListener(SpinHandler);

        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpinHandler()
    {
        gameManager.SpinCard();
    }
}
