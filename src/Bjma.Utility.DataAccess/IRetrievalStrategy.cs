// Copyright 2012, Ben Aston (ben@bj.ma).
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

	public interface IRetrievalStrategy<out TAggregateRoot> where TAggregateRoot : IAggregateRoot, ISerializable
	{
		TAggregateRoot Retrieve(string ids);
	}
}