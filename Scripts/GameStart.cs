/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 游戏开始脚本
 *    Description: 
 *           功能：
 *                  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;

namespace PureMVCDemo
{
	public class GameStart : MonoBehaviour {


		void Start () {
            UIManager.GetInstance().ShowUIForms(ProjectConsts.StartUIForm);
		}
		
	}
}