using System;
using System.Collections.Generic;
using ProtoBuf;

namespace VehicleData.Entities.ItemValues
{
    [ProtoContract]
	public class ItemData
	{
		[ProtoMember (1)]
		public int ItemId { get; set; }

		[ProtoMember (2)]
		public string ItemName { get; set; }

		[ProtoMember (3)]
		public string Value { get; set; }

		[ProtoMember (4)]
		public string UnitType { get; set; }

		[ProtoMember (5)]
		public string Icon { get; set; }

		[ProtoMember (6)]
		public int DataTypeId { get; set; }

		[ProtoMember (7)]
		public int CustomTypeId { get; set; }
	}
}