/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.1
 * Contact: support@ory.sh
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

using Ory.Client.Client;
using Ory.Client.Api;
// uncomment below to import models
//using Ory.Client.Model;

namespace Ory.Client.Test.Api
{
    /// <summary>
    ///  Class for testing FrontendApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FrontendApiTests : IDisposable
    {
        private FrontendApi instance;

        public FrontendApiTests()
        {
            instance = new FrontendApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FrontendApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FrontendApi
            //Assert.IsType<FrontendApi>(instance);
        }

        /// <summary>
        /// Test CreateBrowserLoginFlow
        /// </summary>
        [Fact]
        public void CreateBrowserLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //string aal = null;
            //string returnTo = null;
            //string cookie = null;
            //string loginChallenge = null;
            //var response = instance.CreateBrowserLoginFlow(refresh, aal, returnTo, cookie, loginChallenge);
            //Assert.IsType<ClientLoginFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserLogoutFlow
        /// </summary>
        [Fact]
        public void CreateBrowserLogoutFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cookie = null;
            //var response = instance.CreateBrowserLogoutFlow(cookie);
            //Assert.IsType<ClientLogoutFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserRecoveryFlow
        /// </summary>
        [Fact]
        public void CreateBrowserRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //var response = instance.CreateBrowserRecoveryFlow(returnTo);
            //Assert.IsType<ClientRecoveryFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserRegistrationFlow
        /// </summary>
        [Fact]
        public void CreateBrowserRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //string loginChallenge = null;
            //var response = instance.CreateBrowserRegistrationFlow(returnTo, loginChallenge);
            //Assert.IsType<ClientRegistrationFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserSettingsFlow
        /// </summary>
        [Fact]
        public void CreateBrowserSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //string cookie = null;
            //var response = instance.CreateBrowserSettingsFlow(returnTo, cookie);
            //Assert.IsType<ClientSettingsFlow>(response);
        }

        /// <summary>
        /// Test CreateBrowserVerificationFlow
        /// </summary>
        [Fact]
        public void CreateBrowserVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //var response = instance.CreateBrowserVerificationFlow(returnTo);
            //Assert.IsType<ClientVerificationFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeLoginFlow
        /// </summary>
        [Fact]
        public void CreateNativeLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //string aal = null;
            //string xSessionToken = null;
            //var response = instance.CreateNativeLoginFlow(refresh, aal, xSessionToken);
            //Assert.IsType<ClientLoginFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeRecoveryFlow
        /// </summary>
        [Fact]
        public void CreateNativeRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateNativeRecoveryFlow();
            //Assert.IsType<ClientRecoveryFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeRegistrationFlow
        /// </summary>
        [Fact]
        public void CreateNativeRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateNativeRegistrationFlow();
            //Assert.IsType<ClientRegistrationFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeSettingsFlow
        /// </summary>
        [Fact]
        public void CreateNativeSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //var response = instance.CreateNativeSettingsFlow(xSessionToken);
            //Assert.IsType<ClientSettingsFlow>(response);
        }

        /// <summary>
        /// Test CreateNativeVerificationFlow
        /// </summary>
        [Fact]
        public void CreateNativeVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateNativeVerificationFlow();
            //Assert.IsType<ClientVerificationFlow>(response);
        }

        /// <summary>
        /// Test DisableMyOtherSessions
        /// </summary>
        [Fact]
        public void DisableMyOtherSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.DisableMyOtherSessions(xSessionToken, cookie);
            //Assert.IsType<ClientDeleteMySessionsCount>(response);
        }

        /// <summary>
        /// Test DisableMySession
        /// </summary>
        [Fact]
        public void DisableMySessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string xSessionToken = null;
            //string cookie = null;
            //instance.DisableMySession(id, xSessionToken, cookie);
        }

        /// <summary>
        /// Test GetFlowError
        /// </summary>
        [Fact]
        public void GetFlowErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFlowError(id);
            //Assert.IsType<ClientFlowError>(response);
        }

        /// <summary>
        /// Test GetLoginFlow
        /// </summary>
        [Fact]
        public void GetLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetLoginFlow(id, cookie);
            //Assert.IsType<ClientLoginFlow>(response);
        }

        /// <summary>
        /// Test GetRecoveryFlow
        /// </summary>
        [Fact]
        public void GetRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetRecoveryFlow(id, cookie);
            //Assert.IsType<ClientRecoveryFlow>(response);
        }

        /// <summary>
        /// Test GetRegistrationFlow
        /// </summary>
        [Fact]
        public void GetRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetRegistrationFlow(id, cookie);
            //Assert.IsType<ClientRegistrationFlow>(response);
        }

        /// <summary>
        /// Test GetSettingsFlow
        /// </summary>
        [Fact]
        public void GetSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.GetSettingsFlow(id, xSessionToken, cookie);
            //Assert.IsType<ClientSettingsFlow>(response);
        }

        /// <summary>
        /// Test GetVerificationFlow
        /// </summary>
        [Fact]
        public void GetVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetVerificationFlow(id, cookie);
            //Assert.IsType<ClientVerificationFlow>(response);
        }

        /// <summary>
        /// Test GetWebAuthnJavaScript
        /// </summary>
        [Fact]
        public void GetWebAuthnJavaScriptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWebAuthnJavaScript();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test ListMySessions
        /// </summary>
        [Fact]
        public void ListMySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.ListMySessions(perPage, page, xSessionToken, cookie);
            //Assert.IsType<List<ClientSession>>(response);
        }

        /// <summary>
        /// Test PerformNativeLogout
        /// </summary>
        [Fact]
        public void PerformNativeLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientPerformNativeLogoutBody clientPerformNativeLogoutBody = null;
            //instance.PerformNativeLogout(clientPerformNativeLogoutBody);
        }

        /// <summary>
        /// Test ToSession
        /// </summary>
        [Fact]
        public void ToSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.ToSession(xSessionToken, cookie);
            //Assert.IsType<ClientSession>(response);
        }

        /// <summary>
        /// Test UpdateLoginFlow
        /// </summary>
        [Fact]
        public void UpdateLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientUpdateLoginFlowBody clientUpdateLoginFlowBody = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.UpdateLoginFlow(flow, clientUpdateLoginFlowBody, xSessionToken, cookie);
            //Assert.IsType<ClientSuccessfulNativeLogin>(response);
        }

        /// <summary>
        /// Test UpdateLogoutFlow
        /// </summary>
        [Fact]
        public void UpdateLogoutFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string returnTo = null;
            //instance.UpdateLogoutFlow(token, returnTo);
        }

        /// <summary>
        /// Test UpdateRecoveryFlow
        /// </summary>
        [Fact]
        public void UpdateRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientUpdateRecoveryFlowBody clientUpdateRecoveryFlowBody = null;
            //string token = null;
            //string cookie = null;
            //var response = instance.UpdateRecoveryFlow(flow, clientUpdateRecoveryFlowBody, token, cookie);
            //Assert.IsType<ClientRecoveryFlow>(response);
        }

        /// <summary>
        /// Test UpdateRegistrationFlow
        /// </summary>
        [Fact]
        public void UpdateRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientUpdateRegistrationFlowBody clientUpdateRegistrationFlowBody = null;
            //string cookie = null;
            //var response = instance.UpdateRegistrationFlow(flow, clientUpdateRegistrationFlowBody, cookie);
            //Assert.IsType<ClientSuccessfulNativeRegistration>(response);
        }

        /// <summary>
        /// Test UpdateSettingsFlow
        /// </summary>
        [Fact]
        public void UpdateSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientUpdateSettingsFlowBody clientUpdateSettingsFlowBody = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.UpdateSettingsFlow(flow, clientUpdateSettingsFlowBody, xSessionToken, cookie);
            //Assert.IsType<ClientSettingsFlow>(response);
        }

        /// <summary>
        /// Test UpdateVerificationFlow
        /// </summary>
        [Fact]
        public void UpdateVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientUpdateVerificationFlowBody clientUpdateVerificationFlowBody = null;
            //string token = null;
            //string cookie = null;
            //var response = instance.UpdateVerificationFlow(flow, clientUpdateVerificationFlowBody, token, cookie);
            //Assert.IsType<ClientVerificationFlow>(response);
        }
    }
}
