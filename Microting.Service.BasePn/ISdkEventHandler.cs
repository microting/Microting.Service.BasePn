/*
The MIT License (MIT)

Copyright (c) 2007 - 2019 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;

namespace Microting.Service.BasePn
{
    public interface ISdkEventHandler
    {
        void CoreEventException(object sender, EventArgs args);
        void UnitActivated(object sender, EventArgs args);
        void eFormProcessed(object sender, EventArgs args);
        void eFormProcessingError(object sender, EventArgs args);
        void eFormRetrived(object sender, EventArgs args);
        void CaseCompleted(object sender, EventArgs args);
        void CaseDeleted(object sender, EventArgs args);
        void NotificationNotFound(object sender, EventArgs args);
        /// <summary>
        /// This method will start the internal threads if any.
        /// </summary>
        /// <param name="sdkConnectionString">This is required if the plugin is to start the eForm SDK</param>
        /// <param name="serviceLocation"></param>
        /// <returns></returns>
        bool Start(string sdkConnectionString, string serviceLocation);
        /// <summary>
        /// This is to shut down the internal threads the plugin might have started
        /// otherwise it should just return true.
        /// </summary>
        /// <param name="shutdownReallyFast">Optinally implemented so the plugin shuts down really fast</param>
        /// <returns></returns>
        bool Stop(bool shutdownReallyFast);
        /// <summary>
        /// If needed stops and start the internal threads of the plugin
        /// </summary>
        /// <param name="sameExceptionCount"></param>
        /// <param name="sameExceptionCountMax"></param>
        /// <param name="shutdownReallyFast">Optinally implemented so the plugin shuts down really fast</param>
        /// <returns></returns>
        bool Restart(int sameExceptionCount, int sameExceptionCountMax, bool shutdownReallyFast);
    }
}