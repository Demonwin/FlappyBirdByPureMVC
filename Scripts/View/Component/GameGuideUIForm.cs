/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 游戏（玩法）介绍窗体
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
using PureMVC.Patterns;
using SUIFW;
using UnityEngine;

namespace PureMVCDemo
{
	public class GameGuideUIForm : BaseUIForm {

	    void Awake()
	    {
	        //本窗体类型
	        CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;

            //注册按钮事件
	        RigisterButtonObjectEvent("BtnGuideOK", p =>
	        {
                OpenUIForm(ProjectConsts.GamePlayingUIForm);
	            //MVC 启动命令
                Facade.Instance.SendNotification(ProjectConsts.Reg_StartGameCommand);
                //对视图层字段初始化
                Facade.Instance.SendNotification(ProjectConsts.Msg_InitGamePlayingMediatorFiled);
	        }
	        );
	    }

	}
}