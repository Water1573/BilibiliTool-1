﻿using System;
using System.Collections.Generic;
using System.Text;
using Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos;

namespace Ray.BiliBiliTool.DomainService.Interfaces
{
    /// <summary>
    /// 投币
    /// </summary>
    public interface IDonateCoinDomainService : IDomainService
    {
        void AddCoinsForVideos(UserInfo userInfo);

        Tuple<string, string> TryGetCanDonatedVideo();

        bool DoAddCoinForVideo(string aid, int multiply, bool select_like, string title = "");
    }
}
