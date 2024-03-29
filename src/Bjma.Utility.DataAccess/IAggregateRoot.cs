﻿// Copyright 2012, Ben Aston (ben@bj.ma).
// 
// This file is part of Bjma.Utility.DataAccess.
// 
// Bjma.Utility.DataAccess is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Bjma.Utility.DataAccess is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with Bjma.Utility.DataAccess. If not, see <http://www.gnu.org/licenses/>.

namespace Bjma.Utility.DataAccess
{
	using System.Runtime.Serialization;

	/// <summary>
	/// 	Responsible for providing a type to implement to indicate a type is considered suitable for persistence to long-term storage.
	/// </summary>
	public interface IAggregateRoot : ISerializable
	{
		string Id { get; set; } //was_id per CouchDb

		string Revision { get; set; } //was _rev per CouchDb
	}
}