using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class MassageDispacther
{
    public static MassageDispacther instance = new MassageDispacther();
    public MassageDispacther()
    {

    }

    SortedList<DateTime, Telegram> telegramss = new SortedList<DateTime, Telegram>();

    //メッセージを送る関数、誰か送る、誰がもらう、メッセージ
    public void DispatchMassage(TimeSpan delay, BaseGameEntity sender, BaseGameEntity reciever, int msg)
    {
        var telegram = new Telegram(sender,reciever,msg,DateTime.Now + delay);
        //時間が０になってメッセージ送ります。
        if (delay == TimeSpan.Zero)
        {
            Discharge(telegram);
        }
        else
        {
            telegramss.Add(telegram.dispatchTime, telegram);
        }
    }

    private void Discharge(Telegram telegram)
    {
        telegram.reciever.HandleMassage(telegram);
    }
}
