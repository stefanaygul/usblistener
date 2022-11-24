class USBDeviceInfo
{
    public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
    {
        DeviceID = deviceID;
        PnpDeviceID = pnpDeviceID;
        Description = description;
    }

    public string DeviceID { get; private set; }

    public string PnpDeviceID { get; private set; }

    public string Description { get; private set; }
}
