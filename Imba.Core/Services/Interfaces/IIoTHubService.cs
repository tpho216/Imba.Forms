using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Imba.Core.DataModels;

namespace Imba.Core.Services.Interfaces
{
    public interface IIoTHubService
    {
        Task<byte[]> SendC2DMessage(string deviceName, string topic, string message, bool isHex);
        List<Sensor> GetMockedSensors();

    }
}
