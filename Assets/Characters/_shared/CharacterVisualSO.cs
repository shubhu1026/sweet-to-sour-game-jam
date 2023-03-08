using UnityEngine;

[CreateAssetMenu(fileName = "CharacterVisualSO", menuName = "SweetToSour/CharacterVisualSO", order = 0)]
public class CharacterVisualSO : ScriptableObject 
{
    public Sprite Body;
    public Sprite Foot;
    public Sprite Hair;
    public Sprite Hand;
    public Sprite Head;

    public AudioClip[] Steps;
}
