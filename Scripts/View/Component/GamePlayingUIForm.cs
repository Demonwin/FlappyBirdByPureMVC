/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 游戏进行中UI窗体
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
	public class GamePlayingUIForm : BaseUIForm {


		void Awake () {
			//UI窗体类型
            CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;
		}
		
	}
}