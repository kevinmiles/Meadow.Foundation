﻿using System;
using Meadow;
using Meadow.Hardware;
using Meadow.Devices;
using Meadow.Foundation.Sensors.Buttons;

namespace PushButton_Sample
{
    public class PushButtonApp : AppBase<F7Micro, PushButtonApp>
    {
        PushButton pushButton;

        public PushButtonApp()
        {
            Console.WriteLine("Got here 1.");
            pushButton = new PushButton(Device, Device.Pins.D02);

            Console.WriteLine("Got here 2.");
            pushButton.PressStarted += (s, e) => {
                Console.WriteLine("Press started");
            };

            pushButton.PressEnded += (s, e) => {
                Console.WriteLine("Press ended");
            };

            pushButton.Clicked += (s, e) => {
                Console.WriteLine("Button Clicked");
            };

            pushButton.LongPressClicked += (s, e) => {
                Console.WriteLine("Long pressed!");
            };
        }
    }
}