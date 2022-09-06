/*
 * GOV.UK Pay API
 *
 * GOV.UK Pay API
 *
 * The version of the OpenAPI document: 1.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using GovUKPayApiClient.Client;
using GovUKPayApiClient.Model;

namespace GovUKPayApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthoriseCardPaymentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Authorise a MOTO payment
        /// </summary>
        /// <remarks>
        /// Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </remarks>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void AuthoriseAMOTOPayment(AuthorisationRequest authorisationRequest, int operationIndex = 0);

        /// <summary>
        /// Authorise a MOTO payment
        /// </summary>
        /// <remarks>
        /// Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </remarks>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AuthoriseAMOTOPaymentWithHttpInfo(AuthorisationRequest authorisationRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthoriseCardPaymentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Authorise a MOTO payment
        /// </summary>
        /// <remarks>
        /// Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </remarks>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AuthoriseAMOTOPaymentAsync(AuthorisationRequest authorisationRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Authorise a MOTO payment
        /// </summary>
        /// <remarks>
        /// Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </remarks>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AuthoriseAMOTOPaymentWithHttpInfoAsync(AuthorisationRequest authorisationRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthoriseCardPaymentsApi : IAuthoriseCardPaymentsApiSync, IAuthoriseCardPaymentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthoriseCardPaymentsApi : IAuthoriseCardPaymentsApi
    {
        private GovUKPayApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthoriseCardPaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthoriseCardPaymentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthoriseCardPaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthoriseCardPaymentsApi(string basePath)
        {
            this.Configuration = GovUKPayApiClient.Client.Configuration.MergeConfigurations(
                GovUKPayApiClient.Client.GlobalConfiguration.Instance,
                new GovUKPayApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new GovUKPayApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GovUKPayApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = GovUKPayApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthoriseCardPaymentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthoriseCardPaymentsApi(GovUKPayApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = GovUKPayApiClient.Client.Configuration.MergeConfigurations(
                GovUKPayApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new GovUKPayApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new GovUKPayApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = GovUKPayApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthoriseCardPaymentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthoriseCardPaymentsApi(GovUKPayApiClient.Client.ISynchronousClient client, GovUKPayApiClient.Client.IAsynchronousClient asyncClient, GovUKPayApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = GovUKPayApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public GovUKPayApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public GovUKPayApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public GovUKPayApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public GovUKPayApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Authorise a MOTO payment Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </summary>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void AuthoriseAMOTOPayment(AuthorisationRequest authorisationRequest, int operationIndex = 0)
        {
            AuthoriseAMOTOPaymentWithHttpInfo(authorisationRequest);
        }

        /// <summary>
        /// Authorise a MOTO payment Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </summary>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public GovUKPayApiClient.Client.ApiResponse<Object> AuthoriseAMOTOPaymentWithHttpInfo(AuthorisationRequest authorisationRequest, int operationIndex = 0)
        {
            // verify the required parameter 'authorisationRequest' is set
            if (authorisationRequest == null)
            {
                throw new GovUKPayApiClient.Client.ApiException(400, "Missing required parameter 'authorisationRequest' when calling AuthoriseCardPaymentsApi->AuthoriseAMOTOPayment");
            }

            GovUKPayApiClient.Client.RequestOptions localVarRequestOptions = new GovUKPayApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = GovUKPayApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GovUKPayApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = authorisationRequest;

            localVarRequestOptions.Operation = "AuthoriseCardPaymentsApi.AuthoriseAMOTOPayment";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/auth", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthoriseAMOTOPayment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Authorise a MOTO payment Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </summary>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AuthoriseAMOTOPaymentAsync(AuthorisationRequest authorisationRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AuthoriseAMOTOPaymentWithHttpInfoAsync(authorisationRequest, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Authorise a MOTO payment Authorise a payment that was created with &#x60;authorisation_mode&#x60; set to &#x60;moto_api&#x60;.
        /// </summary>
        /// <exception cref="GovUKPayApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorisationRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<GovUKPayApiClient.Client.ApiResponse<Object>> AuthoriseAMOTOPaymentWithHttpInfoAsync(AuthorisationRequest authorisationRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'authorisationRequest' is set
            if (authorisationRequest == null)
            {
                throw new GovUKPayApiClient.Client.ApiException(400, "Missing required parameter 'authorisationRequest' when calling AuthoriseCardPaymentsApi->AuthoriseAMOTOPayment");
            }


            GovUKPayApiClient.Client.RequestOptions localVarRequestOptions = new GovUKPayApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = GovUKPayApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = GovUKPayApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = authorisationRequest;

            localVarRequestOptions.Operation = "AuthoriseCardPaymentsApi.AuthoriseAMOTOPayment";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/auth", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AuthoriseAMOTOPayment", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
