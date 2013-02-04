﻿/*
 * Copyright 2013 (c) Inish Technology Ventures Limited.  All rights reserved.
 * 
 * This code is licensed under the BSD 3-Clause License included with this source
 * 
 * ALSO SEE: https://github.com/SoftwarePotential/samples/wiki/License
 * 
 */

// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.

using System;
using System.ComponentModel.DataAnnotations;

namespace Sp.Samples.LicenseManagement.Store.Models
{
	public class CatalogEntryModel
	{
		public int Id { get; set; }
		[ Display( Name="Product Name" ) ]
		[ Required ]
		public string ProductName { get; set; }
		[ Display( Name="Product Version" ) ]
		[ Required ]
		public string ProductVersion { get; set; }
		public string Blurb { get; set; }
		[Required( ErrorMessage = "A SkuId is required. Visit srv.softwarepotential.com to obtain/create a valid SkuId for this product." )]
		public string SkuId { get; set; }
		public Nullable<decimal> Price { get; set; }
	}
}