using UnityEngine;
using System.Collections;

public abstract class State<Entitype> where Entitype : BaseGameEntity
{
    //こちらは概要のクラス
    public abstract GameObject target
    {
        get;
    }

    //ステート入ります
    public abstract void Enter(Entitype entity);
    //ステートを実行します
    public abstract void Execute(Entitype entity);
    //ステート出ます
    public abstract void Exit(Entitype entity);
    //メッセージの管理
    public abstract bool handelMassage(Entitype enity, Telegram tele);
}
