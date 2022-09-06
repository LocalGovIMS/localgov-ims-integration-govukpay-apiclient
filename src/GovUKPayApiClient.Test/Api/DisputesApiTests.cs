/*
 * GOV.UK Pay API
 *
 * GOV.UK Pay API
 *
 * The version of the OpenAPI document: 1.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using GovUKPayApiClient.Client;
using GovUKPayApiClient.Api;
// uncomment below to import models
//using GovUKPayApiClient.Model;

namespace GovUKPayApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing DisputesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DisputesApiTests : IDisposable
    {
        private DisputesApi instance;

        public DisputesApiTests()
        {
            instance = new DisputesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DisputesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DisputesApi
            //Assert.IsType<DisputesApi>(instance);
        }

        /// <summary>
        /// Test SearchDisputes
        /// </summary>
        [Fact]
        public void SearchDisputesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fromDate = null;
            //string toDate = null;
            //string fromSettledDate = null;
            //string toSettledDate = null;
            //string status = null;
            //string page = null;
            //string displaySize = null;
            //var response = instance.SearchDisputes(fromDate, toDate, fromSettledDate, toSettledDate, status, page, displaySize);
            //Assert.IsType<DisputesSearchResults>(response);
        }
    }
}
