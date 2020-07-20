using UnityEngine;
using System.Collections;

public class MinerGlobalState : State<Miner>
{
    //マイナーのグローバルステートの管理
    public static MinerGlobalState instance = new MinerGlobalState();
    private MinerGlobalState()
    {

    }

    public override GameObject target
    {
        get
        {
            return null;
        }
    }
    public override void Enter(Miner entity)
    {

    }

    public override void Execute(Miner entity)
    {

    }

    public override void Exit(Miner entity)
    {

    }

    public override bool handelMassage(Miner entity, Telegram tele)
    {
        return false;
    }


}
