﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.Enums
{
    /// <summary>
    /// 命令单元
    /// </summary>
    public enum JTNEMsgId:byte
    {
        /// <summary>
        /// 车辆登入
        /// </summary>
        login = 0x01,
        /// <summary>
        /// 实时信息上传
        /// </summary>
        uploadim = 0x02,
        /// <summary>
        /// 补传信息上传
        /// </summary>
        uploadsup = 0x03,
        /// <summary>
        /// 车辆登出
        /// </summary>
        loginout = 0x04,
        /// <summary>
        /// 平台登入
        /// </summary>
        platformlogin = 0x05,
        /// <summary>
        /// 平台登出
        /// </summary>
        platformlogout = 0x06,
        /// <summary>
        /// 心跳
        /// </summary>
        heartbeat = 0x07,
        /// <summary>
        /// 终端校时
        /// </summary>
        checktime = 0x08,
        /// <summary>
        /// 查询命令
        /// </summary>
        query = 0x80,
        /// <summary>
        /// 设置命令
        /// </summary>
        settings = 0x81,
        /// <summary>
        /// 控制命令
        /// </summary>
        control = 0x82
    }
}
