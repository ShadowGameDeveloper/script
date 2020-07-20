using UnityEngine;
using System.Collections;

public class EnterMineAndDigForNugget : State<Miner>
{
    public static EnterMineAndDigForNugget instance = new EnterMineAndDigForNugget();

    private EnterMineAndDigForNugget()
    {

    }

    public override GameObject target
    {
        get
        {
            return Directory.instance.mine;
        }
    }

    public override void Enter(Miner entity)
    {
       
    }

    public override void Execute(Miner entity)
    {
        //ゴールド探すときゴールドと倦怠感が増えました
        entity.goldPerson++;
        entity.fatigue++;
        //ポケットがいっぱいになったら銀行へいきます。
        if (entity.PocketFull())
        {
            entity.stateMachine.TravelTo(VisitBankAndStoreGold.instance);
        }

        

    }

    public override void Exit(Miner entity)
    {

    }

    public override bool handelMassage(Miner entity, Telegram tele)
    {
        return false;
    }
}
