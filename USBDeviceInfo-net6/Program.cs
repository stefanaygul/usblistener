#pragma warning disable CA1416 // Validate platform compatibility

using System.Management;

static List<USBDeviceInfo> GetUSBDevices()
{
    using var managementObjectSearcher = new ManagementObjectSearcher("Select * From Win32_USBHub");
    using var objectCollection = managementObjectSearcher.Get();

    var usbDevices = new List<USBDeviceInfo>();
    foreach (ManagementBaseObject managementBaseObject in objectCollection)
    {
        usbDevices.Add(new USBDeviceInfo(
            (string)managementBaseObject.GetPropertyValue("DeviceID"),
            (string)managementBaseObject.GetPropertyValue("PNPDeviceID"),
            (string)managementBaseObject.GetPropertyValue("Description")));
    }

    return usbDevices;
}

while (true)
{
    foreach (USBDeviceInfo usbDevice in GetUSBDevices())
    {
        Console.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}", (object)usbDevice.DeviceID, (object)usbDevice.PnpDeviceID, (object)usbDevice.Description);
    }

    Console.WriteLine("Wait 10 Secs");
    Thread.Sleep(10000);
}
