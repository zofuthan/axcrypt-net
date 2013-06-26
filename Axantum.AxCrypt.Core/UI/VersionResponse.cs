﻿#region Coypright and License

/*
 * AxCrypt - Copyright 2012, Svante Seleborg, All Rights Reserved
 *
 * This file is part of AxCrypt.
 *
 * AxCrypt is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * AxCrypt is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with AxCrypt.  If not, see <http://www.gnu.org/licenses/>.
 *
 * The source is maintained at http://bitbucket.org/axantum/axcrypt-net please visit for
 * updates, contributions and contact with the author. You may also visit
 * http://www.axantum.com for more information about the author.
*/

#endregion Coypright and License

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace Axantum.AxCrypt.Core.UI
{
    [DataContract]
    public class VersionResponse
    {
        /// <summary>
        /// Status
        /// </summary>
        [DataMember(Name = "S")]
        public int Status { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [DataMember(Name = "M")]
        public string Message { get; set; }

        /// <summary>
        /// Url where new version may be found
        /// </summary>
        [DataMember(Name = "U")]
        public string WebReference { get; set; }

        /// <summary>
        /// String serialization of the full version
        /// </summary>
        [DataMember(Name = "V")]
        public string Version { get; set; }

        /// <summary>
        /// The revision only
        /// </summary>
        [DataMember(Name = "R")]
        public int Revision { get; set; }
    }
}