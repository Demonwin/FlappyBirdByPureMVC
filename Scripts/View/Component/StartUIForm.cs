/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 游戏首UI界面
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
	public class StartUIForm : BaseUIForm {


        void Awake()
        {
            //按钮注册
            RigisterButtonObjectEvent("ImgBackground",p=>
                OpenUIForm(ProjectConsts.GameGuideUIForm)
                );
        }

	    void Start()
	    {
	        //启动MVC 框架
	        new ApplicationFacade();
	    }
	}
}