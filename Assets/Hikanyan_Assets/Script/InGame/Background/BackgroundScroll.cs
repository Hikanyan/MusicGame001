using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed;
    float textureSizeX;

    private void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureSizeX = texture.width / sprite.pixelsPerUnit;
    }
    private void Update()
    {
        transform.position -= new Vector3(scrollSpeed * Time.deltaTime, 0);
        if (Mathf.Abs(transform.position.x) >= textureSizeX)
        {
            float offsetPostitionX = transform.position.x % textureSizeX;
            transform.position = new Vector3(offsetPostitionX, 0);
        }
    }
}
