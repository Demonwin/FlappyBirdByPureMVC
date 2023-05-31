/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 模型层--> 实体类
 *    Description: 
 *           功能：定义小鸟的相关数据
 *                 1：时间。
 *                 2：分数。
 *                 3：最高分数
 *                  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVCDemo
{
	public class Model_GameData {
        //游戏时间
	    public int GameTime { set; get; }
        //游戏分数
	    public int Scores { set; get; }
        //游戏最高分数
	    public int HightestScores { set; get; }

	}
}