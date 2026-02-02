using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using w4d3CheckOutAPI.Models;

namespace w4d3CheckOutAPI.Services;

    public interface IDeviceService
    {
        //What of our project

        //create Function for our CRUD

        // CREATE
        Device AddDevice(Device newDevice);
        // READ
        List<Device> GetDevices();
        
        Device? GetDeviceById(int id);
        // UPDATE
        Device? UpdateDevice(int id, Device updatedDevice);
        // DELETE
        bool DeleteDevice(int id);
    }
