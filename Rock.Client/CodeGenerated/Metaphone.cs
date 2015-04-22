//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for Metaphone that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class MetaphoneEntity
    {
        /// <summary />
        public string Metaphone1 { get; set; }

        /// <summary />
        public string Metaphone2 { get; set; }

        /// <summary />
        public string Name { get; set; }

    }

    /// <summary>
    /// Client model for Metaphone that includes all the fields that are available for GETs. Use this for GETs (use MetaphoneEntity for POST/PUTs)
    /// </summary>
    public partial class Metaphone : MetaphoneEntity
    {
    }
}