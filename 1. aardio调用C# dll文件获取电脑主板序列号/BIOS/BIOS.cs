using System.Management;

namespace BIOS
{
    public class BIOS
    {

        // 获取主板序列号
        public string GetBIOSSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_BIOS");
                string serialNumber = "";
                foreach (ManagementObject info in searcher.Get())
                {
                    serialNumber = info["SerialNumber"].ToString().Trim();
                }

                return serialNumber;
            }
            catch
            {
                return "";
            }
        }

    }
}
