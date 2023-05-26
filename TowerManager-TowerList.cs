//TowerManager-TowerList.cs
// 这个代码块主要是教玩家如何建造不同类型的防御塔
// 以及介绍一些不同类型的防御塔的属性
//
using UnityEngine;

public class MachineTower : MonoBehaviour //MonoBehaviour允许在游戏对象中对属性进行微调和参数设置
{
    public string towerName = "MachineTower"; //这是一个机枪塔

    //防御塔类型
    public string towerType = "Attack"; //这是一个攻击类型的防御塔

    //基本属性
    public float towerATKFloat = 5.0f; //塔防的基础伤害[浮点]，5点攻击力
    public int towerATKInt = 5; //塔防的基础伤害[整数]，5点攻击力

    // 浮点攻击力以及整数攻击力取决于之后赋值的参数。
    // 如果创造的道具加成是整数参数：+20点攻击力
    // 如果创造的道具加成是浮点参数：+20% 攻击力

    public bool towerMagicAttack = false; //防御塔不支持魔法攻击，用布尔值判断
    public float towerAttackSpeed = 3.0f; //防御塔的基础攻击速度
    public float towerAttackRange = 2.0f; //防御塔的基础攻击范围
}

    //辅助型防御塔：
    //防御塔类型
    //基本属性

    //功能型防御塔：
    //防御塔类型
    //基本属性

    //高级防御塔：
    //防御塔类型
    //基本属性

    //传说级防御塔：
    //防御塔类型
    //基本属性


    //目前还未完善，知道如何完善的用户可自行修改代码，代码越简单越好，也要方便维护和扩展
    //如果是静态类，请帮我添加静态类文件
