using UnityEngine;

[CreateAssetMenu(fileName = "CharacterVisualSO", menuName = "SweetToSour/CharacterVisualSO", order = 0)]
public class CharacterVisualSO : ScriptableObject {
    public Sprite body;
    public Sprite foot;
    public Sprite hair;
    public Sprite hand;
    public Sprite head;

    public AudioClip[] steps;
}
