﻿using XDM.Core;

namespace XDM.Core.BrowserMonitoring
{
    public static class BrowserMonitor
    {
        public static void RunHttpIpcHandler()
        {
            var handler = new IpcHttpHandler();
            handler.StartHttpIpcChannel();
        }

        public static void RunNativeHostHandler()
        {
            var handler = new NativeMessagingHostHandler();
            handler.StartPipedChannel();
        }
    }
}
