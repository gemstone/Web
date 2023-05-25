﻿//******************************************************************************************************
//  WebExtensions.cs - Gbtc
//
//  Copyright © 2022, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/11/2020 - Billy Ernest
//       Generated original version of source code.
//
//******************************************************************************************************

using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace Gemstone.Web
{
    /// <summary>
    /// Defines extension methods useful for web applications.
    /// </summary>
    public static class WebExtensions
    {
        /// <summary>
        /// Used to create <see cref="StaticFileOptions"/> for serving Gemstone.Web embedded javascript and css stylesheets.
        /// </summary>
        /// <returns><see cref="StaticFileOptions"/></returns>
        public static StaticFileOptions StaticFileEmbeddedResources() {
            ManifestEmbeddedFileProvider embeddedFileProvider = new(Assembly.GetExecutingAssembly(), "Shared");
            return new StaticFileOptions
            {
                FileProvider = embeddedFileProvider,
                RequestPath = new PathString("/@Gemstone")
            };
        }
    }
}
