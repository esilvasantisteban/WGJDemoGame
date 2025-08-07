using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyStrokeVisualizer : MonoBehaviour
{
    public List<KeyStrokeVisualizerData> keys;

    private void Update()
    {
        keys.ForEach(keyStrokeData =>
        {
            if (Input.GetKey(keyStrokeData.key)) {
                keyStrokeData.spriteRenderer.sprite = keyStrokeData.heldSprite;
            }
            else
            {
                keyStrokeData.spriteRenderer.sprite = keyStrokeData.sprite;
            }
        });
    }
}

[System.Serializable]
public class KeyStrokeVisualizerData
{
    public Image spriteRenderer;
    public Sprite sprite;
    public Sprite heldSprite;
    public string key;
}

