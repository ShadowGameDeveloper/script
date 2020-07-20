﻿using UnityEngine;
using System.Collections;

public class StateMAchine<EntityType> where EntityType : BaseGameEntity
{
    EntityType owner;
    State<EntityType> currentState;
    State<EntityType> globalState;
    State<EntityType> previousState;
    State<EntityType> travelToState;

    internal GameObject target;
    State<EntityType> destinationtoState;

    //ステートの管理
    public StateMAchine(EntityType owner,State<EntityType> currentState, State<EntityType> globalState)
    {
        this.owner = owner;
        TravelTo(currentState);
        this.globalState = globalState;
    }


    //ステート変わるとき
    public void ChangeState(State<EntityType> newState)
    {
        MonoBehaviour.print(newState.GetType());
        if (currentState != null)
        {
            currentState.Exit(owner);
        }
        currentState = newState;
        currentState.Enter(owner);
    }
    
    //メッセージ管理
    public void HandleMassage(Telegram tele)
    {
        if (currentState.handelMassage(owner, tele))
        {
            return;
        }
        if (globalState.handelMassage(owner, tele))
        {
            return;
        }
    }

    //前のステート戻ります
    public void RevertToPerviousState()
    {
        ChangeState(previousState);
    }

    //ステート実行する
    public void Execute()
    {
        if (globalState != null)
        {
            globalState.Execute(owner);
        }
        if (currentState != null)
        {
            currentState.Execute(owner);
        }

        if (target != null)
        {
            owner.transform.position = Vector3.MoveTowards(owner.transform.position, target.transform.position, owner.moveSpeed * Time.deltaTime);


            if (owner.transform.position == target.transform.position)
            {

                target = null;
                ChangeState(destinationtoState);
            }
        }
    }

    //ステートのGameObjectに多動します
    public void TravelTo(State<EntityType> destinationtoState)
    {
        target = destinationtoState.target;
        this.destinationtoState = destinationtoState;
        ChangeState(new Travel<EntityType>(destinationtoState));
    }

}
