using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w4d3CheckOutAPI.Models;

namespace w4d3CheckOutAPI.Services;

public class DeviceService : IDeviceService
{

    List<Device> _deviceList = new();

    // constructor CTOR
    public DeviceService()
    {
        _deviceList.Add(new Device
        {
            Id = 1,
            Name = "Dell",
            Type = "Laptop",
            SerialNumber = "SN-1234",
            IsCheckOut = true
        });

        _deviceList.Add(new Device
        {
            Id = 2,
            Name = "Ipad",
            Type = "Tablet",
            SerialNumber = "SN-56789",
            IsCheckOut = false
        });
    }

    // CREATE   
    public Device AddDevice(Device newDevice)
    {
        int newID = _deviceList.Count == 0 ? 1 : _deviceList.Max(d => d.Id) + 1;

        newDevice.Id = newID;

        _deviceList.Add(newDevice);
        return newDevice;
    }
    // DELETE
    public bool DeleteDevice(int id)
    {
        Device? device= _deviceList.FirstOrDefault(d=>d.Id==id);
        if (device == null)
        {
            return false;
        }
        _deviceList.Remove(device);
        return true;
    }
    // READ
    public Device? GetDeviceById(int id)
    {
        return _deviceList.FirstOrDefault(d=>d.Id==id);
    }
    // READ
    public List<Device> GetDevices()
    {
        return _deviceList;
    }
    // UPDATE
    public Device? UpdateDevice(int id, Device updatedDevice)
    {
        Device? existingDevice= _deviceList.FirstOrDefault(d=>d.Id==id);

        if (existingDevice ==null)
        {
            return null;
        }
        existingDevice.Name=updatedDevice.Name;
        existingDevice.Type=updatedDevice.Type;
        existingDevice.SerialNumber=updatedDevice.SerialNumber;
        existingDevice.IsCheckOut=updatedDevice.IsCheckOut;

        return existingDevice;
    }
}
