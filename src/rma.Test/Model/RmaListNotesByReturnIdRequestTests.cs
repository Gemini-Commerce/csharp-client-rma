/*
 * RMA Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using rma.Model;
using rma.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace rma.Test.Model
{
    /// <summary>
    ///  Class for testing RmaListNotesByReturnIdRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RmaListNotesByReturnIdRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RmaListNotesByReturnIdRequest
        //private RmaListNotesByReturnIdRequest instance;

        public RmaListNotesByReturnIdRequestTests()
        {
            // TODO uncomment below to create an instance of RmaListNotesByReturnIdRequest
            //instance = new RmaListNotesByReturnIdRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RmaListNotesByReturnIdRequest
        /// </summary>
        [Fact]
        public void RmaListNotesByReturnIdRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RmaListNotesByReturnIdRequest
            //Assert.IsType<RmaListNotesByReturnIdRequest>(instance);
        }

        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
        }

        /// <summary>
        /// Test the property 'ReturnId'
        /// </summary>
        [Fact]
        public void ReturnIdTest()
        {
            // TODO unit test for the property 'ReturnId'
        }

        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Fact]
        public void PageSizeTest()
        {
            // TODO unit test for the property 'PageSize'
        }

        /// <summary>
        /// Test the property 'PageToken'
        /// </summary>
        [Fact]
        public void PageTokenTest()
        {
            // TODO unit test for the property 'PageToken'
        }

        /// <summary>
        /// Test the property 'Sorts'
        /// </summary>
        [Fact]
        public void SortsTest()
        {
            // TODO unit test for the property 'Sorts'
        }
    }
}