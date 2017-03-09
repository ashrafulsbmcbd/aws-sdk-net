/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a <code>BatchWrite</code> response operation.
    /// </summary>
    public partial class BatchWriteOperationResponse
    {
        private BatchAddFacetToObjectResponse _addFacetToObject;
        private BatchAttachObjectResponse _attachObject;
        private BatchCreateObjectResponse _createObject;
        private BatchDeleteObjectResponse _deleteObject;
        private BatchDetachObjectResponse _detachObject;
        private BatchRemoveFacetFromObjectResponse _removeFacetFromObject;
        private BatchUpdateObjectAttributesResponse _updateObjectAttributes;

        /// <summary>
        /// Gets and sets the property AddFacetToObject. 
        /// <para>
        /// Result of an add facet to object batch operation.
        /// </para>
        /// </summary>
        public BatchAddFacetToObjectResponse AddFacetToObject
        {
            get { return this._addFacetToObject; }
            set { this._addFacetToObject = value; }
        }

        // Check to see if AddFacetToObject property is set
        internal bool IsSetAddFacetToObject()
        {
            return this._addFacetToObject != null;
        }

        /// <summary>
        /// Gets and sets the property AttachObject. 
        /// <para>
        /// Attaches an object to a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchAttachObjectResponse AttachObject
        {
            get { return this._attachObject; }
            set { this._attachObject = value; }
        }

        // Check to see if AttachObject property is set
        internal bool IsSetAttachObject()
        {
            return this._attachObject != null;
        }

        /// <summary>
        /// Gets and sets the property CreateObject. 
        /// <para>
        /// Creates an object in a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchCreateObjectResponse CreateObject
        {
            get { return this._createObject; }
            set { this._createObject = value; }
        }

        // Check to see if CreateObject property is set
        internal bool IsSetCreateObject()
        {
            return this._createObject != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteObject. 
        /// <para>
        /// Deletes an object in a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDeleteObjectResponse DeleteObject
        {
            get { return this._deleteObject; }
            set { this._deleteObject = value; }
        }

        // Check to see if DeleteObject property is set
        internal bool IsSetDeleteObject()
        {
            return this._deleteObject != null;
        }

        /// <summary>
        /// Gets and sets the property DetachObject. 
        /// <para>
        /// Detaches an object from a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDetachObjectResponse DetachObject
        {
            get { return this._detachObject; }
            set { this._detachObject = value; }
        }

        // Check to see if DetachObject property is set
        internal bool IsSetDetachObject()
        {
            return this._detachObject != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveFacetFromObject. 
        /// <para>
        /// Result of a batch remove facet from object operation.
        /// </para>
        /// </summary>
        public BatchRemoveFacetFromObjectResponse RemoveFacetFromObject
        {
            get { return this._removeFacetFromObject; }
            set { this._removeFacetFromObject = value; }
        }

        // Check to see if RemoveFacetFromObject property is set
        internal bool IsSetRemoveFacetFromObject()
        {
            return this._removeFacetFromObject != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateObjectAttributes. 
        /// <para>
        /// Updates a given object’s attributes.
        /// </para>
        /// </summary>
        public BatchUpdateObjectAttributesResponse UpdateObjectAttributes
        {
            get { return this._updateObjectAttributes; }
            set { this._updateObjectAttributes = value; }
        }

        // Check to see if UpdateObjectAttributes property is set
        internal bool IsSetUpdateObjectAttributes()
        {
            return this._updateObjectAttributes != null;
        }

    }
}