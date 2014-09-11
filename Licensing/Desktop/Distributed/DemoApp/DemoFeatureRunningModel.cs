﻿/*
 * Copyright (c) Inish Technology Ventures Limited.  All rights reserved.
 * 
 * This code is licensed under the BSD 3-Clause License included with this source
 * 
 * ALSO SEE: https://github.com/SoftwarePotential/samples/blob/master/License.txt
 * 
 */

using System;
using DemoApp.BusinessLogic;
using DemoApp.Common;

namespace DemoApp
{
	class DemoFeatureRunningModel : ViewModelBase
	{
		public RelayCommand<int> RunFeatureCommand { get; set; }

		public DemoFeatureRunningModel()
		{
			RunFeatureCommand = new RelayCommand<int>( RunFeature, _ => true, Convert.ToInt32 );
		}

		public void RunFeature( int featureNumber )
		{
			switch ( featureNumber )
			{
				case 1: MyAlgorithms.AccessFeature1();
					break;
				case 2: MyAlgorithms.AccessFeature2();
					break;
				case 3: MyAlgorithms.AccessFeature3();
					break;
				default:
					throw new ArgumentOutOfRangeException( "featureNumber" );
			}
			LastSuccessfulFeatureExecutionMessage = string.Format( "Feature {0} accessed successfully", featureNumber );
		}

		string _lastSuccessfulFeatureExecutionMessage;

		public string LastSuccessfulFeatureExecutionMessage
		{
			get { return _lastSuccessfulFeatureExecutionMessage; }
			set
			{
				_lastSuccessfulFeatureExecutionMessage = value;
				OnPropertyChanged( "LastSuccessfulFeatureExecutionMessage" );
			}
		}
	}
}