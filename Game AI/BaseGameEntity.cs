using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGameEntity : MonoBehaviour
{
    //動きスピードの設定
    public float moveSpeed = 0.01f;
    //メッセージ
    public abstract void HandleMassage(Telegram tele);
}
