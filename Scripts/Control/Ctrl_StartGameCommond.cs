/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 命令层(控制层)--> 开始游戏
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
using UnityEngine;

namespace PureMVCDemo
{
    public class Ctrl_StartGameCommond : MacroCommand
    {
        protected override void InitializeMacroCommand()
        {
            //注册模型与视图Command
            AddSubCommand(typeof(Ctrl_RigistModelAndViewCommand));
            //注册重新开始command
            AddSubCommand(typeof(Ctrl_ReStartGameCommond));
        }
    }
}