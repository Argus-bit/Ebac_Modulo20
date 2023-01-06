using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]

public class ColorChange : MonoBehaviour
{
    public float duration = .2f;
    public MeshRenderer meshRenderer;

    public Color startColor = Color.white;
    private Color _currentColor;

    private void OnValidate()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        _currentColor = meshRenderer.materials[0].GetColor("_Color");
        LerpColor();
    }
    private void LerpColor()
    {
        meshRenderer.materials[0].SetColor("_Color", startColor);
        meshRenderer.materials[0].DOColor(_currentColor, duration).SetDelay(.5f);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            LerpColor();
        }
    }
}
