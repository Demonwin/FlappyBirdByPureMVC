/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 命令层--> 注册模型与视图层
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
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

namespace PureMVCDemo
{
    public class Ctrl_RigistModelAndViewCommand : SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            Facade.RegisterProxy(new Model_GameDataProxy());
            Facade.RegisterMediator(new Vew_GamePlayingMediator());
        }
    }
}