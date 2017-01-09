﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync.IRC.MessageFilter.Filters.Ban
{
    class IBanMessageFilters : FilterBase
    {
        protected BanManager bindManager = null;

        protected IBanMessageFilters() { }

        public IBanMessageFilters(BanManager manager)
        {
            SetBanManager(manager);
        }

        /// <summary>
        /// 钦定过滤器绑定的管理器
        /// </summary>
        /// <param name="manager"></param>
        public void SetBanManager(BanManager manager)
        {
            bindManager = manager;
        }

        public override void onMsg(ref MessageBase msg)
        {
            throw new NotImplementedException();
        }
    }
}
