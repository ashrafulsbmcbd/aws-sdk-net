/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Start time for the action.
    /// </summary>
    public partial class FixedModeScheduleActionStartSettings
    {
        private string _time;

        /// <summary>
        /// Gets and sets the property Time. Start time for the action to start in the channel.
        /// (Not the time for the action to be added to the schedule: actions are always added
        /// to the schedule immediately.) UTC format: yyyy-mm-ddThh:mm:ss.nnnZ. All the letters
        /// are digits (for example, mm might be 01) except for the two constants "T" for time
        /// and "Z" for "UTC format".
        /// </summary>
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

    }
}