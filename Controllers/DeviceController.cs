using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using w4d3CheckOutAPI.Models;
using w4d3CheckOutAPI.Services;

namespace w4d3CheckOutAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DeviceController : ControllerBase
{
    private readonly IDeviceService _deviceService;
    public DeviceController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    // Read all
    [HttpGet("GetDeviceList")]
    public List<Device> GetDevices()
    {
        return _deviceService.GetDevices();
    }

    // Read by Id

    [HttpGet("GetDeviceById/{id}")]
    public Device? GetDeviceById(int id)
    {
        return _deviceService.GetDeviceById(id);
    }

    // create
    [HttpPost("AddDevice/{id}")]
    public Device AddDevice(Device device)
    {
        return _deviceService.AddDevice(device);
    }

    // update
    [HttpPut("updateDevice/{id}")]
    public Device? UpdateDevice(int id, Device device)
    {
        return _deviceService.UpdateDevice(id,device);
    }
    // delete
    [HttpDelete("removeDevice/{id}")]
    public bool DeleteDevice(int id)
    {
        return _deviceService.DeleteDevice(id);
    }
}
