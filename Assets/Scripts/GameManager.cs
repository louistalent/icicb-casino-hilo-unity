using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [Header("Material")]
    [SerializeField] Material _jokerMaterial;
    [SerializeField] Material[] _redMaterials;
    [SerializeField] Material[] _blackMaterials;

    [Header("GameObject")]
    [SerializeField] GameObject _Card;

    private Animator rotationAnim;
    private bool _spining;

    // Start is called before the first frame update
    void Start()
    {
        rotationAnim = _Card.GetComponent<Animator>();
        _spining = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpinCard()
    {
        if (_spining) return;

        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        _spining = true;

        rotationAnim.SetBool("rotation", true);
        float interval = Random.Range(2f, 4f);
        yield return new WaitForSeconds(3f);

        int colorFlag = Random.Range(0, 2);
        if (colorFlag == 1)
        {
            int materialIndex = Random.Range(0, 12);
            _Card.GetComponent<MeshRenderer>().material = _redMaterials[materialIndex];
        }
        else
        {
            int materialIndex = Random.Range(0, 12);
            _Card.GetComponent<MeshRenderer>().material = _blackMaterials[materialIndex];
        }

        rotationAnim.SetBool("rotation", false);
        yield return new WaitForSeconds(0.15f);

        _spining = false;
    }
}
