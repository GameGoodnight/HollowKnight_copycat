using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//직렬화
[Serializable]

public class userData : MonoBehaviour
{
    public int playerOfHp;//현재 체력
    public int playerManaPoint;//현재 마나
    public int monsterCnt;//몬스터 잡은 횟수
    public int moneyCnt;//획득한 돈
    public int jumpCnt;//점프 횟수
    public int attackCnt;//공격 횟수
    public int hitCnt;//공격 명중률
    public int playerMoney;//현재 소지금
    public int playerSoulMoney;//영혼 소지금
    public int takeAttack;//피격횟수
    public int deathCnt;//죽은 횟수
    public int bossCnt;//보스몹 잡은 횟수
    public int[] soulPosition = new int[4];
    public bool[] savePoint = new bool[2];
}
