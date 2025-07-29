using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Net;
using System.Diagnostics;

namespace YatirimTakip.Helpers
{
    public class NetworkConnection : IDisposable
    {
        [DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int WNetAddConnection3A(
            ref NETRESOURCE lpNetResource,
            string lpPassword,
            string lpUsername,
            uint dwFlags);

        [DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int WNetCancelConnection2(
            string lpName,
            uint dwFlags,
            bool fForce);

        [StructLayout(LayoutKind.Sequential)]
        private struct NETRESOURCE
        {
            public uint dwScope;
            public uint dwType;
            public uint dwDisplayType;
            public uint dwUsage;
            public string lpLocalName;
            public string lpRemoteName;
            public string lpComment;
            public string lpProvider;
        }

        private readonly string _networkPath;

        public NetworkConnection(string networkPath, NetworkCredential credentials)
        {
            _networkPath = networkPath;

            var netResource = new NETRESOURCE
            {
                dwType = 0, // RESOURCETYPE_DISK
                lpRemoteName = networkPath,
                dwScope = 2,
                dwDisplayType = 0,
                dwUsage = 0,
                lpLocalName = null,
                lpProvider = null,
                lpComment = null
            };

            int result = WNetAddConnection3A(
                ref netResource,
                credentials.Password,
                credentials.UserName,
                0);

            if (result != 0)
            {
                //throw new Win32Exception(result, "Ağ paylaşımına bağlanılamadı");
                int lastError = Marshal.GetLastWin32Error();
                Debug.WriteLine($"API Hata Kodu: {lastError}");
                Debug.WriteLine($"Marshal Error: {Marshal.GetExceptionForHR(lastError)?.Message}");

            }
        }

        public void Dispose()
        {
            WNetCancelConnection2(_networkPath, 0, true);
        }
    }
}

