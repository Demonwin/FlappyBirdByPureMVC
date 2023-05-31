/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 控制层--> 管道控制脚本
 *    Description: 
 *           功能：单个管道碰撞检测。
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

    [RequireComponent(typeof(BoxCollider2D))]
    public class Ctrl_PipeAndLand : MonoBehaviour {

        /// <summary>
        /// 2D碰撞检测
        /// </summary>
        /// <param name="collision"></param>
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag==ProjectConsts.Player)
            {
                //通过PureMVC的通知，游戏结束。
                Facade.Instance.SendNotification(ProjectConsts.Reg_EndGameCommand);
            }
        }
    }
}