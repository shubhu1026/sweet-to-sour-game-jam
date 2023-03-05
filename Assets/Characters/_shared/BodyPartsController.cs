using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartsController : MonoBehaviour
{
    [SerializeField] SpriteRenderer headSpriteRenderer;
    [SerializeField] SpriteRenderer hairSpriteRenderer;
    [SerializeField] SpriteRenderer torsoSpriteRenderer;
    [SerializeField] SpriteRenderer handRSpriteRenderer;
    [SerializeField] SpriteRenderer handLSpriteRenderer;
    [SerializeField] SpriteRenderer footRSpriteRenderer;
    [SerializeField] SpriteRenderer footLSpriteRenderer;

    [SerializeField] CharacterVisualSO characterVisualData;

    private void Start()
    {
        SetCharacterVisual(characterVisualData);
    }
    public void SetCharacterVisual(CharacterVisualSO characterVisualData)
    {
        this.characterVisualData = characterVisualData;

        headSpriteRenderer.sprite = characterVisualData.head;
        hairSpriteRenderer.sprite = characterVisualData.hair;
        torsoSpriteRenderer.sprite = characterVisualData.body;
        handRSpriteRenderer.sprite = characterVisualData.hand;
        handLSpriteRenderer.sprite = characterVisualData.hand;
        footRSpriteRenderer.sprite = characterVisualData.foot;
        footLSpriteRenderer.sprite = characterVisualData.foot;
    }
}
