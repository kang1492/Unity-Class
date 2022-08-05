using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/Item", order =0)]

public class Item1 : ScriptableObject
{
    public int price;    
    public Sprite itemBoader;
    public Sprite itemPicture;
    public Sprite PurchasePicture; // 버튼 눌러 구입

}
