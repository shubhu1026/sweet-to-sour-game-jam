using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GUIInGame : MonoBehaviour
{
    public static GUIInGame Instance;
    [SerializeField] private GameObject _visual;
    [SerializeField] private TextMeshProUGUI _textMesh;
    [SerializeField] private float _timeToDisspear;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        transform.GetComponentInParent<CharacterControllerTopDown>().onDirectionChanged += Flip;
        HideText();
    }
    public void ShowText(string text)
    {
        _visual.SetActive(true);
        _textMesh.text = text;
        StartCoroutine(DisableText());
    }
    private IEnumerator DisableText()
    {
        yield return new WaitForSeconds(_timeToDisspear);
        HideText();
    }
    private void HideText()
    {
        _visual.SetActive(true);
    }
    private void Flip(int xDirection)
    {
        transform.localScale = new Vector3(xDirection, transform.localScale.y, transform.localScale.z);
    }
}
