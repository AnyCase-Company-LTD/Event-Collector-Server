﻿using System;
using System.Collections.Generic;
using System.Text;
using EventCollectorServer.Database.Entities;
using EventCollectorServer.Database.Interfaces;
using MongoDB.Bson.Serialization;

namespace EventCollectorServer.Database.Core.Configurations
{
	public class OfficeClimateSensorsSetDataConfiguration: IEntityMapConfiguration 
	{
		public void Configure()
		{
			BsonClassMap.RegisterClassMap<OfficeClimateSensorsSetData>(classMap =>
			{
				classMap.AutoMap();
				classMap.MapIdMember(member => member.Id);
				classMap.MapMember(member => member.CO2);
				classMap.MapMember(member => member.Humidity);
				classMap.MapMember(member => member.Temperature);
			});
		}
	}
}
