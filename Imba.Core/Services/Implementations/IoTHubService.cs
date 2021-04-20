using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Imba.Core.DataModels;
using Imba.Core.Helpers;
using Imba.Core.Services.Interfaces;
using Microsoft.Azure.Devices;
using Microsoft.Extensions.Configuration;

namespace Imba.Core.Services.Implementations
{
    public class IoTHubService : IIoTHubService
    {
        private readonly ServiceClient _serviceClient;

        /* Unused yet

        public IoTHubService(IConfiguration configuration)
        {
            _serviceClient = ServiceClient.CreateFromConnectionString(configuration.GetValue<string>("AzureIoTHub:ConnectionString"));
        }
        */


        public IoTHubService()
        {

        }

        /* unused yet
// <summary>
        /// Returns HEX value sent to device
        /// </summary>
        /// <param name="deviceName"></param>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <param name="isHex"></param>
        /// <returns></returns>
        public async Task<byte[]> SendC2DMessage(string deviceName, string topic, string message, bool isHex)
        {
            // Note: separate bytes array used to return bytes response as message can only be read once
            byte[] bytes;
            Message commandMessage;

            if (isHex)
            {
                if (!BigInteger.TryParse(message, System.Globalization.NumberStyles.HexNumber, null, out BigInteger parsed))
                {
                    throw new ServiceException(HttpStatusCode.BadRequest, "Provided hex is invalid");
                }

                // Note: BigInteger reverses the order of hex string hence reverse is used to normalise it
                bytes = parsed.ToByteArray().Reverse().ToArray();
                commandMessage = new Message(bytes);
            }
            else
            {
                bytes = Encoding.ASCII.GetBytes(message);
                commandMessage = new Message(bytes);
            }

            try
            {
                commandMessage.Properties.Add("topic", topic);
                await _serviceClient.SendAsync(deviceName, commandMessage);
                return bytes;
            }
            catch (Exception e)
            {
                throw new ServiceException(HttpStatusCode.InternalServerError, e.Message);
            }
        }
*/


        public List<Sensor> GetMockedSensors()
        {
            List<Sensor> mockedSensors = new List<Sensor>
                {
                    new Sensor
                    {
                        Name  = "Electrical Conductivity: Air",
                        Result = "Air: 12345ABCD"
                    }
                    ,
                    new Sensor
                    {
                        Name = "Dissolved Oxygen: DO Solution",
                        Result = "DO Solution: 12345ABCD"
                    }

                };

            return mockedSensors; 

        }

        public Task<byte[]> SendC2DMessage(string deviceName, string topic, string message, bool isHex)
        {
            return null;
            //throw new NotImplementedException();
        }
    }



}
