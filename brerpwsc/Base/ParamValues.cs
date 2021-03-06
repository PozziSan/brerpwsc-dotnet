////
/// Copyright (c) 2016 Saúl Piña <sauljabin@gmail.com>.
/// 
/// This file is part of idempierewsc.
/// 
/// idempierewsc is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Lesser General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
/// 
/// idempierewsc is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Lesser General Public License for more details.
/// 
/// You should have received a copy of the GNU Lesser General Public License
/// along with idempierewsc.  If not, see <http://www.gnu.org/licenses/>.
////


using WebService.Base.Enums;

namespace WebService.Base {

    /// <summary>
    /// Contains the web service fields for run process
    /// </summary>
    public class ParamValues : FieldsContainer {

        /// <summary>
        /// Get the node root name
        /// </summary>
        /// <returns>DataRow</returns>  
        public override FieldsContainerType GetWebServiceFieldsContainerType() {
            return FieldsContainerType.ParamValues;
        }
    }
}
