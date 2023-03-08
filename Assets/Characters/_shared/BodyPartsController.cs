using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartsController : MonoBehaviour
{
    [SerializeField] SpriteRenderer _headSpriteRenderer;
    [SerializeField] SpriteRenderer _hairSpriteRenderer;
    [SerializeField] SpriteRenderer _torsoSpriteRenderer;
    [SerializeField] SpriteRenderer _handRSpriteRenderer;
    [SerializeField] SpriteRenderer _handLSpriteRenderer;
    [SerializeField] SpriteRenderer _footRSpriteRenderer;
    [SerializeField] SpriteRenderer _footLSpriteRenderer;

    [SerializeField] CharacterVisualSO _characterVisualData;

    private void Start()
    {
        SetCharacterVisual(_characterVisualData);
    }

    public void SetCharacterVisual(CharacterVisualSO characterVisualData)
    {
        _characterVisualData = characterVisualData;

        _headSpriteRenderer.sprite = characterVisualData.Head;
        _hairSpriteRenderer.sprite = characterVisualData.Hair;
        _torsoSpriteRenderer.sprite = characterVisualData.Body;
        _handRSpriteRenderer.sprite = characterVisualData.Hand;
        _handLSpriteRenderer.sprite = characterVisualData.Hand;
        _footRSpriteRenderer.sprite = characterVisualData.Foot;
        _footLSpriteRenderer.sprite = characterVisualData.Foot;
    }
}
