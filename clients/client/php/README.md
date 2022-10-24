# ory/client-php

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed
with a valid Personal Access Token. Public APIs are mostly used in browsers.



## Installation & Usage

### Requirements

PHP 7.3 and later.
Should also work with PHP 8.0 but has not been tested.

### Composer

To install the bindings via [Composer](https://getcomposer.org/), add the following to `composer.json`:

```json
{
  "repositories": [
    {
      "type": "vcs",
      "url": "https://github.com/ory/client-php.git"
    }
  ],
  "require": {
    "ory/client-php": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
<?php
require_once('/path/to/ory/client-php/vendor/autoload.php');
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');




$apiInstance = new Ory\Client\Api\AdminApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = 'id_example'; // string | The id of the OAuth 2.0 Client.
$updateOAuth2ClientLifespans = new \Ory\Client\Model\UpdateOAuth2ClientLifespans(); // \Ory\Client\Model\UpdateOAuth2ClientLifespans

try {
    $result = $apiInstance->updateOAuth2ClientLifespans($id, $updateOAuth2ClientLifespans);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AdminApi->updateOAuth2ClientLifespans: ', $e->getMessage(), PHP_EOL;
}

```

## API Endpoints

All URIs are relative to *https://playground.projects.oryapis.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**updateOAuth2ClientLifespans**](docs/Api/AdminApi.md#updateoauth2clientlifespans) | **PUT** /admin/clients/{id}/lifespans | 
*MetadataApi* | [**getVersion**](docs/Api/MetadataApi.md#getversion) | **GET** /version | Return Running Software Version.
*MetadataApi* | [**isAlive**](docs/Api/MetadataApi.md#isalive) | **GET** /health/alive | Check HTTP Server Status
*MetadataApi* | [**isReady**](docs/Api/MetadataApi.md#isready) | **GET** /health/ready | Check HTTP Server and Database Status
*NamespacesApi* | [**getNamespaces**](docs/Api/NamespacesApi.md#getnamespaces) | **GET** /namespaces | Query namespaces
*ReadApi* | [**getCheck**](docs/Api/ReadApi.md#getcheck) | **GET** /relation-tuples/check/openapi | Check a relation tuple
*ReadApi* | [**getCheckMirrorStatus**](docs/Api/ReadApi.md#getcheckmirrorstatus) | **GET** /relation-tuples/check | Check a relation tuple
*ReadApi* | [**getExpand**](docs/Api/ReadApi.md#getexpand) | **GET** /relation-tuples/expand | Expand a Relation Tuple
*ReadApi* | [**getRelationTuples**](docs/Api/ReadApi.md#getrelationtuples) | **GET** /relation-tuples | Query relation tuples
*ReadApi* | [**postCheck**](docs/Api/ReadApi.md#postcheck) | **POST** /relation-tuples/check/openapi | Check a relation tuple
*ReadApi* | [**postCheckMirrorStatus**](docs/Api/ReadApi.md#postcheckmirrorstatus) | **POST** /relation-tuples/check | Check a relation tuple
*SyntaxApi* | [**checkOplSyntax**](docs/Api/SyntaxApi.md#checkoplsyntax) | **POST** /opl/syntax/check | Check the syntax of an OPL file
*V0alpha2Api* | [**adminAcceptOAuth2ConsentRequest**](docs/Api/V0alpha2Api.md#adminacceptoauth2consentrequest) | **PUT** /admin/oauth2/auth/requests/consent/accept | Accept an OAuth 2.0 Consent Request
*V0alpha2Api* | [**adminAcceptOAuth2LoginRequest**](docs/Api/V0alpha2Api.md#adminacceptoauth2loginrequest) | **PUT** /admin/oauth2/auth/requests/login/accept | Accept an OAuth 2.0 Login Request
*V0alpha2Api* | [**adminAcceptOAuth2LogoutRequest**](docs/Api/V0alpha2Api.md#adminacceptoauth2logoutrequest) | **PUT** /admin/oauth2/auth/requests/logout/accept | Accept an OAuth 2.0 Logout Request
*V0alpha2Api* | [**adminCreateIdentity**](docs/Api/V0alpha2Api.md#admincreateidentity) | **POST** /admin/identities | Create an Identity
*V0alpha2Api* | [**adminCreateJsonWebKeySet**](docs/Api/V0alpha2Api.md#admincreatejsonwebkeyset) | **POST** /admin/keys/{set} | Generate a New JSON Web Key
*V0alpha2Api* | [**adminCreateOAuth2Client**](docs/Api/V0alpha2Api.md#admincreateoauth2client) | **POST** /admin/clients | Create an OAuth 2.0 Client
*V0alpha2Api* | [**adminCreateSelfServiceRecoveryCode**](docs/Api/V0alpha2Api.md#admincreateselfservicerecoverycode) | **POST** /admin/recovery/code | Create a Recovery Link
*V0alpha2Api* | [**adminCreateSelfServiceRecoveryLink**](docs/Api/V0alpha2Api.md#admincreateselfservicerecoverylink) | **POST** /admin/recovery/link | Create a Recovery Link
*V0alpha2Api* | [**adminDeleteIdentity**](docs/Api/V0alpha2Api.md#admindeleteidentity) | **DELETE** /admin/identities/{id} | Delete an Identity
*V0alpha2Api* | [**adminDeleteIdentitySessions**](docs/Api/V0alpha2Api.md#admindeleteidentitysessions) | **DELETE** /admin/identities/{id}/sessions | Calling this endpoint irrecoverably and permanently deletes and invalidates all sessions that belong to the given Identity.
*V0alpha2Api* | [**adminDeleteJsonWebKey**](docs/Api/V0alpha2Api.md#admindeletejsonwebkey) | **DELETE** /admin/keys/{set}/{kid} | Delete a JSON Web Key
*V0alpha2Api* | [**adminDeleteJsonWebKeySet**](docs/Api/V0alpha2Api.md#admindeletejsonwebkeyset) | **DELETE** /admin/keys/{set} | Delete a JSON Web Key Set
*V0alpha2Api* | [**adminDeleteOAuth2Client**](docs/Api/V0alpha2Api.md#admindeleteoauth2client) | **DELETE** /admin/clients/{id} | Deletes an OAuth 2.0 Client
*V0alpha2Api* | [**adminDeleteOAuth2Token**](docs/Api/V0alpha2Api.md#admindeleteoauth2token) | **DELETE** /admin/oauth2/tokens | Delete OAuth2 Access Tokens from a Client
*V0alpha2Api* | [**adminDeleteTrustedOAuth2JwtGrantIssuer**](docs/Api/V0alpha2Api.md#admindeletetrustedoauth2jwtgrantissuer) | **DELETE** /admin/trust/grants/jwt-bearer/issuers/{id} | Delete a Trusted OAuth2 JWT Bearer Grant Type Issuer
*V0alpha2Api* | [**adminExtendSession**](docs/Api/V0alpha2Api.md#adminextendsession) | **PATCH** /admin/sessions/{id}/extend | Calling this endpoint extends the given session ID. If &#x60;session.earliest_possible_extend&#x60; is set it will only extend the session after the specified time has passed.
*V0alpha2Api* | [**adminGetIdentity**](docs/Api/V0alpha2Api.md#admingetidentity) | **GET** /admin/identities/{id} | Get an Identity
*V0alpha2Api* | [**adminGetJsonWebKey**](docs/Api/V0alpha2Api.md#admingetjsonwebkey) | **GET** /admin/keys/{set}/{kid} | Fetch a JSON Web Key
*V0alpha2Api* | [**adminGetJsonWebKeySet**](docs/Api/V0alpha2Api.md#admingetjsonwebkeyset) | **GET** /admin/keys/{set} | Retrieve a JSON Web Key Set
*V0alpha2Api* | [**adminGetOAuth2Client**](docs/Api/V0alpha2Api.md#admingetoauth2client) | **GET** /admin/clients/{id} | Get an OAuth 2.0 Client
*V0alpha2Api* | [**adminGetOAuth2ConsentRequest**](docs/Api/V0alpha2Api.md#admingetoauth2consentrequest) | **GET** /admin/oauth2/auth/requests/consent | Get OAuth 2.0 Consent Request Information
*V0alpha2Api* | [**adminGetOAuth2LoginRequest**](docs/Api/V0alpha2Api.md#admingetoauth2loginrequest) | **GET** /admin/oauth2/auth/requests/login | Get an OAuth 2.0 Login Request
*V0alpha2Api* | [**adminGetOAuth2LogoutRequest**](docs/Api/V0alpha2Api.md#admingetoauth2logoutrequest) | **GET** /admin/oauth2/auth/requests/logout | Get an OAuth 2.0 Logout Request
*V0alpha2Api* | [**adminGetTrustedOAuth2JwtGrantIssuer**](docs/Api/V0alpha2Api.md#admingettrustedoauth2jwtgrantissuer) | **GET** /admin/trust/grants/jwt-bearer/issuers/{id} | Get a Trusted OAuth2 JWT Bearer Grant Type Issuer
*V0alpha2Api* | [**adminIntrospectOAuth2Token**](docs/Api/V0alpha2Api.md#adminintrospectoauth2token) | **POST** /admin/oauth2/introspect | Introspect OAuth2 Access or Refresh Tokens
*V0alpha2Api* | [**adminListCourierMessages**](docs/Api/V0alpha2Api.md#adminlistcouriermessages) | **GET** /admin/courier/messages | List Messages
*V0alpha2Api* | [**adminListIdentities**](docs/Api/V0alpha2Api.md#adminlistidentities) | **GET** /admin/identities | List Identities
*V0alpha2Api* | [**adminListIdentitySessions**](docs/Api/V0alpha2Api.md#adminlistidentitysessions) | **GET** /admin/identities/{id}/sessions | This endpoint returns all sessions that belong to the given Identity.
*V0alpha2Api* | [**adminListOAuth2Clients**](docs/Api/V0alpha2Api.md#adminlistoauth2clients) | **GET** /admin/clients | List OAuth 2.0 Clients
*V0alpha2Api* | [**adminListOAuth2SubjectConsentSessions**](docs/Api/V0alpha2Api.md#adminlistoauth2subjectconsentsessions) | **GET** /admin/oauth2/auth/sessions/consent | List OAuth 2.0 Consent Sessions of a Subject
*V0alpha2Api* | [**adminListTrustedOAuth2JwtGrantIssuers**](docs/Api/V0alpha2Api.md#adminlisttrustedoauth2jwtgrantissuers) | **GET** /admin/trust/grants/jwt-bearer/issuers | List Trusted OAuth2 JWT Bearer Grant Type Issuers
*V0alpha2Api* | [**adminPatchIdentity**](docs/Api/V0alpha2Api.md#adminpatchidentity) | **PATCH** /admin/identities/{id} | Patch an Identity
*V0alpha2Api* | [**adminPatchOAuth2Client**](docs/Api/V0alpha2Api.md#adminpatchoauth2client) | **PATCH** /admin/clients/{id} | Patch an OAuth 2.0 Client
*V0alpha2Api* | [**adminRejectOAuth2ConsentRequest**](docs/Api/V0alpha2Api.md#adminrejectoauth2consentrequest) | **PUT** /admin/oauth2/auth/requests/consent/reject | Reject an OAuth 2.0 Consent Request
*V0alpha2Api* | [**adminRejectOAuth2LoginRequest**](docs/Api/V0alpha2Api.md#adminrejectoauth2loginrequest) | **PUT** /admin/oauth2/auth/requests/login/reject | Reject an OAuth 2.0 Login Request
*V0alpha2Api* | [**adminRejectOAuth2LogoutRequest**](docs/Api/V0alpha2Api.md#adminrejectoauth2logoutrequest) | **PUT** /admin/oauth2/auth/requests/logout/reject | Reject an OAuth 2.0 Logout Request
*V0alpha2Api* | [**adminRevokeOAuth2ConsentSessions**](docs/Api/V0alpha2Api.md#adminrevokeoauth2consentsessions) | **DELETE** /admin/oauth2/auth/sessions/consent | Revokes OAuth 2.0 Consent Sessions of a Subject for a Specific OAuth 2.0 Client
*V0alpha2Api* | [**adminRevokeOAuth2LoginSessions**](docs/Api/V0alpha2Api.md#adminrevokeoauth2loginsessions) | **DELETE** /admin/oauth2/auth/sessions/login | Invalidates All OAuth 2.0 Login Sessions of a Certain User
*V0alpha2Api* | [**adminTrustOAuth2JwtGrantIssuer**](docs/Api/V0alpha2Api.md#admintrustoauth2jwtgrantissuer) | **POST** /admin/trust/grants/jwt-bearer/issuers | Trust an OAuth2 JWT Bearer Grant Type Issuer
*V0alpha2Api* | [**adminUpdateIdentity**](docs/Api/V0alpha2Api.md#adminupdateidentity) | **PUT** /admin/identities/{id} | Update an Identity
*V0alpha2Api* | [**adminUpdateJsonWebKey**](docs/Api/V0alpha2Api.md#adminupdatejsonwebkey) | **PUT** /admin/keys/{set}/{kid} | Update a JSON Web Key
*V0alpha2Api* | [**adminUpdateJsonWebKeySet**](docs/Api/V0alpha2Api.md#adminupdatejsonwebkeyset) | **PUT** /admin/keys/{set} | Update a JSON Web Key Set
*V0alpha2Api* | [**adminUpdateOAuth2Client**](docs/Api/V0alpha2Api.md#adminupdateoauth2client) | **PUT** /admin/clients/{id} | Update an OAuth 2.0 Client
*V0alpha2Api* | [**createProject**](docs/Api/V0alpha2Api.md#createproject) | **POST** /projects | Create a Project
*V0alpha2Api* | [**createProjectApiKey**](docs/Api/V0alpha2Api.md#createprojectapikey) | **POST** /projects/{project}/tokens | Create API Token
*V0alpha2Api* | [**createSelfServiceLogoutFlowUrlForBrowsers**](docs/Api/V0alpha2Api.md#createselfservicelogoutflowurlforbrowsers) | **GET** /self-service/logout/browser | Create a Logout URL for Browsers
*V0alpha2Api* | [**deleteProjectApiKey**](docs/Api/V0alpha2Api.md#deleteprojectapikey) | **DELETE** /projects/{project}/tokens/{token_id} | Delete API Token
*V0alpha2Api* | [**discoverJsonWebKeys**](docs/Api/V0alpha2Api.md#discoverjsonwebkeys) | **GET** /.well-known/jwks.json | Discover JSON Web Keys
*V0alpha2Api* | [**discoverOidcConfiguration**](docs/Api/V0alpha2Api.md#discoveroidcconfiguration) | **GET** /.well-known/openid-configuration | OpenID Connect Discovery
*V0alpha2Api* | [**dynamicClientRegistrationCreateOAuth2Client**](docs/Api/V0alpha2Api.md#dynamicclientregistrationcreateoauth2client) | **POST** /oauth2/register | Register an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*V0alpha2Api* | [**dynamicClientRegistrationDeleteOAuth2Client**](docs/Api/V0alpha2Api.md#dynamicclientregistrationdeleteoauth2client) | **DELETE** /oauth2/register/{id} | Deletes an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*V0alpha2Api* | [**dynamicClientRegistrationGetOAuth2Client**](docs/Api/V0alpha2Api.md#dynamicclientregistrationgetoauth2client) | **GET** /oauth2/register/{id} | Get an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*V0alpha2Api* | [**dynamicClientRegistrationUpdateOAuth2Client**](docs/Api/V0alpha2Api.md#dynamicclientregistrationupdateoauth2client) | **PUT** /oauth2/register/{id} | Update an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*V0alpha2Api* | [**getIdentitySchema**](docs/Api/V0alpha2Api.md#getidentityschema) | **GET** /schemas/{id} | 
*V0alpha2Api* | [**getOidcUserInfo**](docs/Api/V0alpha2Api.md#getoidcuserinfo) | **GET** /userinfo | OpenID Connect Userinfo
*V0alpha2Api* | [**getProject**](docs/Api/V0alpha2Api.md#getproject) | **GET** /projects/{project_id} | Get a Project
*V0alpha2Api* | [**getProjectMembers**](docs/Api/V0alpha2Api.md#getprojectmembers) | **GET** /projects/{project_id}/members | Get all members associated with this project.
*V0alpha2Api* | [**getSelfServiceError**](docs/Api/V0alpha2Api.md#getselfserviceerror) | **GET** /self-service/errors | Get Self-Service Errors
*V0alpha2Api* | [**getSelfServiceLoginFlow**](docs/Api/V0alpha2Api.md#getselfserviceloginflow) | **GET** /self-service/login/flows | Get Login Flow
*V0alpha2Api* | [**getSelfServiceRecoveryFlow**](docs/Api/V0alpha2Api.md#getselfservicerecoveryflow) | **GET** /self-service/recovery/flows | Get Recovery Flow
*V0alpha2Api* | [**getSelfServiceRegistrationFlow**](docs/Api/V0alpha2Api.md#getselfserviceregistrationflow) | **GET** /self-service/registration/flows | Get Registration Flow
*V0alpha2Api* | [**getSelfServiceSettingsFlow**](docs/Api/V0alpha2Api.md#getselfservicesettingsflow) | **GET** /self-service/settings/flows | Get Settings Flow
*V0alpha2Api* | [**getSelfServiceVerificationFlow**](docs/Api/V0alpha2Api.md#getselfserviceverificationflow) | **GET** /self-service/verification/flows | Get Verification Flow
*V0alpha2Api* | [**getWebAuthnJavaScript**](docs/Api/V0alpha2Api.md#getwebauthnjavascript) | **GET** /.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*V0alpha2Api* | [**initializeSelfServiceLoginFlowForBrowsers**](docs/Api/V0alpha2Api.md#initializeselfserviceloginflowforbrowsers) | **GET** /self-service/login/browser | Initialize Login Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceLoginFlowWithoutBrowser**](docs/Api/V0alpha2Api.md#initializeselfserviceloginflowwithoutbrowser) | **GET** /self-service/login/api | Initialize Login Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceRecoveryFlowForBrowsers**](docs/Api/V0alpha2Api.md#initializeselfservicerecoveryflowforbrowsers) | **GET** /self-service/recovery/browser | Initialize Recovery Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceRecoveryFlowWithoutBrowser**](docs/Api/V0alpha2Api.md#initializeselfservicerecoveryflowwithoutbrowser) | **GET** /self-service/recovery/api | Initialize Recovery Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceRegistrationFlowForBrowsers**](docs/Api/V0alpha2Api.md#initializeselfserviceregistrationflowforbrowsers) | **GET** /self-service/registration/browser | Initialize Registration Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceRegistrationFlowWithoutBrowser**](docs/Api/V0alpha2Api.md#initializeselfserviceregistrationflowwithoutbrowser) | **GET** /self-service/registration/api | Initialize Registration Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceSettingsFlowForBrowsers**](docs/Api/V0alpha2Api.md#initializeselfservicesettingsflowforbrowsers) | **GET** /self-service/settings/browser | Initialize Settings Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceSettingsFlowWithoutBrowser**](docs/Api/V0alpha2Api.md#initializeselfservicesettingsflowwithoutbrowser) | **GET** /self-service/settings/api | Initialize Settings Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceVerificationFlowForBrowsers**](docs/Api/V0alpha2Api.md#initializeselfserviceverificationflowforbrowsers) | **GET** /self-service/verification/browser | Initialize Verification Flow for Browser Clients
*V0alpha2Api* | [**initializeSelfServiceVerificationFlowWithoutBrowser**](docs/Api/V0alpha2Api.md#initializeselfserviceverificationflowwithoutbrowser) | **GET** /self-service/verification/api | Initialize Verification Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**listIdentitySchemas**](docs/Api/V0alpha2Api.md#listidentityschemas) | **GET** /schemas | 
*V0alpha2Api* | [**listProjectApiKeys**](docs/Api/V0alpha2Api.md#listprojectapikeys) | **GET** /projects/{project}/tokens | List a Project&#39;s API Tokens
*V0alpha2Api* | [**listProjects**](docs/Api/V0alpha2Api.md#listprojects) | **GET** /projects | List All Projects
*V0alpha2Api* | [**listSessions**](docs/Api/V0alpha2Api.md#listsessions) | **GET** /sessions | This endpoints returns all other active sessions that belong to the logged-in user. The current session can be retrieved by calling the &#x60;/sessions/whoami&#x60; endpoint.
*V0alpha2Api* | [**patchProject**](docs/Api/V0alpha2Api.md#patchproject) | **PATCH** /projects/{project_id} | Patch an Ory Cloud Project Configuration&#x60;
*V0alpha2Api* | [**performOAuth2AuthorizationFlow**](docs/Api/V0alpha2Api.md#performoauth2authorizationflow) | **GET** /oauth2/auth | The OAuth 2.0 Authorize Endpoint
*V0alpha2Api* | [**performOAuth2TokenFlow**](docs/Api/V0alpha2Api.md#performoauth2tokenflow) | **POST** /oauth2/token | The OAuth 2.0 Token Endpoint
*V0alpha2Api* | [**performOidcFrontOrBackChannelLogout**](docs/Api/V0alpha2Api.md#performoidcfrontorbackchannellogout) | **GET** /oauth2/sessions/logout | OpenID Connect Front- or Back-channel Enabled Logout
*V0alpha2Api* | [**purgeProject**](docs/Api/V0alpha2Api.md#purgeproject) | **DELETE** /projects/{project_id} | Irrecoverably Purge a Project
*V0alpha2Api* | [**removeProjectMember**](docs/Api/V0alpha2Api.md#removeprojectmember) | **DELETE** /projects/{project_id}/members/{member_id} | Remove a member associated with this project. This also sets their invite status to &#x60;REMOVED&#x60;.
*V0alpha2Api* | [**revokeOAuth2Token**](docs/Api/V0alpha2Api.md#revokeoauth2token) | **POST** /oauth2/revoke | Revoke an OAuth2 Access or Refresh Token
*V0alpha2Api* | [**revokeSession**](docs/Api/V0alpha2Api.md#revokesession) | **DELETE** /sessions/{id} | Calling this endpoint invalidates the specified session. The current session cannot be revoked. Session data are not deleted.
*V0alpha2Api* | [**revokeSessions**](docs/Api/V0alpha2Api.md#revokesessions) | **DELETE** /sessions | Calling this endpoint invalidates all except the current session that belong to the logged-in user. Session data are not deleted.
*V0alpha2Api* | [**submitSelfServiceLoginFlow**](docs/Api/V0alpha2Api.md#submitselfserviceloginflow) | **POST** /self-service/login | Submit a Login Flow
*V0alpha2Api* | [**submitSelfServiceLogoutFlow**](docs/Api/V0alpha2Api.md#submitselfservicelogoutflow) | **GET** /self-service/logout | Complete Self-Service Logout
*V0alpha2Api* | [**submitSelfServiceLogoutFlowWithoutBrowser**](docs/Api/V0alpha2Api.md#submitselfservicelogoutflowwithoutbrowser) | **DELETE** /self-service/logout/api | Perform Logout for APIs, Services, Apps, ...
*V0alpha2Api* | [**submitSelfServiceRecoveryFlow**](docs/Api/V0alpha2Api.md#submitselfservicerecoveryflow) | **POST** /self-service/recovery | Complete Recovery Flow
*V0alpha2Api* | [**submitSelfServiceRegistrationFlow**](docs/Api/V0alpha2Api.md#submitselfserviceregistrationflow) | **POST** /self-service/registration | Submit a Registration Flow
*V0alpha2Api* | [**submitSelfServiceSettingsFlow**](docs/Api/V0alpha2Api.md#submitselfservicesettingsflow) | **POST** /self-service/settings | Complete Settings Flow
*V0alpha2Api* | [**submitSelfServiceVerificationFlow**](docs/Api/V0alpha2Api.md#submitselfserviceverificationflow) | **POST** /self-service/verification | Complete Verification Flow
*V0alpha2Api* | [**toSession**](docs/Api/V0alpha2Api.md#tosession) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To
*V0alpha2Api* | [**updateProject**](docs/Api/V0alpha2Api.md#updateproject) | **PUT** /projects/{project_id} | Update an Ory Cloud Project Configuration
*WriteApi* | [**createRelationTuple**](docs/Api/WriteApi.md#createrelationtuple) | **PUT** /admin/relation-tuples | Create a Relation Tuple
*WriteApi* | [**deleteRelationTuples**](docs/Api/WriteApi.md#deleterelationtuples) | **DELETE** /admin/relation-tuples | Delete Relation Tuples
*WriteApi* | [**patchRelationTuples**](docs/Api/WriteApi.md#patchrelationtuples) | **PATCH** /admin/relation-tuples | Patch Multiple Relation Tuples

## Models

- [AcceptOAuth2ConsentRequest](docs/Model/AcceptOAuth2ConsentRequest.md)
- [AcceptOAuth2ConsentRequestSession](docs/Model/AcceptOAuth2ConsentRequestSession.md)
- [AcceptOAuth2LoginRequest](docs/Model/AcceptOAuth2LoginRequest.md)
- [ActiveProject](docs/Model/ActiveProject.md)
- [AdminCreateIdentityBody](docs/Model/AdminCreateIdentityBody.md)
- [AdminCreateIdentityImportCredentialsOidc](docs/Model/AdminCreateIdentityImportCredentialsOidc.md)
- [AdminCreateIdentityImportCredentialsOidcConfig](docs/Model/AdminCreateIdentityImportCredentialsOidcConfig.md)
- [AdminCreateIdentityImportCredentialsOidcProvider](docs/Model/AdminCreateIdentityImportCredentialsOidcProvider.md)
- [AdminCreateIdentityImportCredentialsPassword](docs/Model/AdminCreateIdentityImportCredentialsPassword.md)
- [AdminCreateIdentityImportCredentialsPasswordConfig](docs/Model/AdminCreateIdentityImportCredentialsPasswordConfig.md)
- [AdminCreateJsonWebKeySetBody](docs/Model/AdminCreateJsonWebKeySetBody.md)
- [AdminCreateSelfServiceRecoveryCodeBody](docs/Model/AdminCreateSelfServiceRecoveryCodeBody.md)
- [AdminCreateSelfServiceRecoveryLinkBody](docs/Model/AdminCreateSelfServiceRecoveryLinkBody.md)
- [AdminIdentityImportCredentials](docs/Model/AdminIdentityImportCredentials.md)
- [AdminTrustOAuth2JwtGrantIssuerBody](docs/Model/AdminTrustOAuth2JwtGrantIssuerBody.md)
- [AdminUpdateIdentityBody](docs/Model/AdminUpdateIdentityBody.md)
- [AuthenticatorAssuranceLevel](docs/Model/AuthenticatorAssuranceLevel.md)
- [CloudAccount](docs/Model/CloudAccount.md)
- [CnameSettings](docs/Model/CnameSettings.md)
- [CourierMessageStatus](docs/Model/CourierMessageStatus.md)
- [CourierMessageType](docs/Model/CourierMessageType.md)
- [CreateCustomHostnameBody](docs/Model/CreateCustomHostnameBody.md)
- [CreateProjectBody](docs/Model/CreateProjectBody.md)
- [CreateSubscriptionPayload](docs/Model/CreateSubscriptionPayload.md)
- [ErrorAuthenticatorAssuranceLevelNotSatisfied](docs/Model/ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
- [ExpandTree](docs/Model/ExpandTree.md)
- [GenericError](docs/Model/GenericError.md)
- [GenericErrorContent](docs/Model/GenericErrorContent.md)
- [GetCheckResponse](docs/Model/GetCheckResponse.md)
- [GetManagedIdentitySchemaLocation](docs/Model/GetManagedIdentitySchemaLocation.md)
- [GetNamespacesResponse](docs/Model/GetNamespacesResponse.md)
- [GetRelationTuplesResponse](docs/Model/GetRelationTuplesResponse.md)
- [HandledOAuth2ConsentRequest](docs/Model/HandledOAuth2ConsentRequest.md)
- [HandledOAuth2LoginRequest](docs/Model/HandledOAuth2LoginRequest.md)
- [HandledOAuth2LogoutRequest](docs/Model/HandledOAuth2LogoutRequest.md)
- [Headers](docs/Model/Headers.md)
- [HealthNotReadyStatus](docs/Model/HealthNotReadyStatus.md)
- [HealthStatus](docs/Model/HealthStatus.md)
- [IDTokenClaims](docs/Model/IDTokenClaims.md)
- [Identity](docs/Model/Identity.md)
- [IdentityCredentials](docs/Model/IdentityCredentials.md)
- [IdentityCredentialsOidc](docs/Model/IdentityCredentialsOidc.md)
- [IdentityCredentialsOidcProvider](docs/Model/IdentityCredentialsOidcProvider.md)
- [IdentityCredentialsPassword](docs/Model/IdentityCredentialsPassword.md)
- [IdentityCredentialsType](docs/Model/IdentityCredentialsType.md)
- [IdentitySchemaContainer](docs/Model/IdentitySchemaContainer.md)
- [IdentitySchemaPreset](docs/Model/IdentitySchemaPreset.md)
- [IdentityState](docs/Model/IdentityState.md)
- [InlineObject3](docs/Model/InlineObject3.md)
- [InlineResponse200](docs/Model/InlineResponse200.md)
- [InlineResponse2001](docs/Model/InlineResponse2001.md)
- [InlineResponse503](docs/Model/InlineResponse503.md)
- [IntrospectedOAuth2Token](docs/Model/IntrospectedOAuth2Token.md)
- [InvitePayload](docs/Model/InvitePayload.md)
- [IsOwnerForProjectBySlug](docs/Model/IsOwnerForProjectBySlug.md)
- [IsOwnerForProjectBySlugPayload](docs/Model/IsOwnerForProjectBySlugPayload.md)
- [JsonError](docs/Model/JsonError.md)
- [JsonPatch](docs/Model/JsonPatch.md)
- [JsonWebKey](docs/Model/JsonWebKey.md)
- [JsonWebKeySet](docs/Model/JsonWebKeySet.md)
- [KetoNamespace](docs/Model/KetoNamespace.md)
- [ManagedIdentitySchema](docs/Model/ManagedIdentitySchema.md)
- [ManagedIdentitySchemaValidationResult](docs/Model/ManagedIdentitySchemaValidationResult.md)
- [Message](docs/Model/Message.md)
- [ModelNamespace](docs/Model/ModelNamespace.md)
- [NeedsPrivilegedSessionError](docs/Model/NeedsPrivilegedSessionError.md)
- [NormalizedProject](docs/Model/NormalizedProject.md)
- [NormalizedProjectRevision](docs/Model/NormalizedProjectRevision.md)
- [NormalizedProjectRevisionHook](docs/Model/NormalizedProjectRevisionHook.md)
- [NormalizedProjectRevisionIdentitySchema](docs/Model/NormalizedProjectRevisionIdentitySchema.md)
- [NormalizedProjectRevisionThirdPartyProvider](docs/Model/NormalizedProjectRevisionThirdPartyProvider.md)
- [NullPlan](docs/Model/NullPlan.md)
- [OAuth2AccessRequest](docs/Model/OAuth2AccessRequest.md)
- [OAuth2ApiError](docs/Model/OAuth2ApiError.md)
- [OAuth2Client](docs/Model/OAuth2Client.md)
- [OAuth2ConsentRequest](docs/Model/OAuth2ConsentRequest.md)
- [OAuth2ConsentRequestOpenIDConnectContext](docs/Model/OAuth2ConsentRequestOpenIDConnectContext.md)
- [OAuth2ConsentSession](docs/Model/OAuth2ConsentSession.md)
- [OAuth2ConsentSessionExpiresAt](docs/Model/OAuth2ConsentSessionExpiresAt.md)
- [OAuth2LoginRequest](docs/Model/OAuth2LoginRequest.md)
- [OAuth2LogoutRequest](docs/Model/OAuth2LogoutRequest.md)
- [OAuth2TokenResponse](docs/Model/OAuth2TokenResponse.md)
- [OidcConfiguration](docs/Model/OidcConfiguration.md)
- [OidcUserInfo](docs/Model/OidcUserInfo.md)
- [Pagination](docs/Model/Pagination.md)
- [PaginationHeaders](docs/Model/PaginationHeaders.md)
- [ParseError](docs/Model/ParseError.md)
- [PatchDelta](docs/Model/PatchDelta.md)
- [PostCheckOplSyntaxResponse](docs/Model/PostCheckOplSyntaxResponse.md)
- [PreviousOAuth2ConsentSession](docs/Model/PreviousOAuth2ConsentSession.md)
- [Project](docs/Model/Project.md)
- [ProjectApiKey](docs/Model/ProjectApiKey.md)
- [ProjectHost](docs/Model/ProjectHost.md)
- [ProjectInvite](docs/Model/ProjectInvite.md)
- [ProjectMetadata](docs/Model/ProjectMetadata.md)
- [ProjectServiceIdentity](docs/Model/ProjectServiceIdentity.md)
- [ProjectServiceOAuth2](docs/Model/ProjectServiceOAuth2.md)
- [ProjectServicePermission](docs/Model/ProjectServicePermission.md)
- [ProjectServices](docs/Model/ProjectServices.md)
- [ProvisionMockSubscriptionPayload](docs/Model/ProvisionMockSubscriptionPayload.md)
- [QuotaCustomDomains](docs/Model/QuotaCustomDomains.md)
- [QuotaProjectMemberSeats](docs/Model/QuotaProjectMemberSeats.md)
- [RecoveryIdentityAddress](docs/Model/RecoveryIdentityAddress.md)
- [RefreshTokenHookRequest](docs/Model/RefreshTokenHookRequest.md)
- [RefreshTokenHookResponse](docs/Model/RefreshTokenHookResponse.md)
- [RejectOAuth2Request](docs/Model/RejectOAuth2Request.md)
- [RelationQuery](docs/Model/RelationQuery.md)
- [RelationTuple](docs/Model/RelationTuple.md)
- [RevokedSessions](docs/Model/RevokedSessions.md)
- [SchemaPatch](docs/Model/SchemaPatch.md)
- [SelfServiceBrowserLocationChangeRequiredError](docs/Model/SelfServiceBrowserLocationChangeRequiredError.md)
- [SelfServiceError](docs/Model/SelfServiceError.md)
- [SelfServiceFlowExpiredError](docs/Model/SelfServiceFlowExpiredError.md)
- [SelfServiceLoginFlow](docs/Model/SelfServiceLoginFlow.md)
- [SelfServiceLogoutUrl](docs/Model/SelfServiceLogoutUrl.md)
- [SelfServiceRecoveryCode](docs/Model/SelfServiceRecoveryCode.md)
- [SelfServiceRecoveryFlow](docs/Model/SelfServiceRecoveryFlow.md)
- [SelfServiceRecoveryFlowState](docs/Model/SelfServiceRecoveryFlowState.md)
- [SelfServiceRecoveryLink](docs/Model/SelfServiceRecoveryLink.md)
- [SelfServiceRegistrationFlow](docs/Model/SelfServiceRegistrationFlow.md)
- [SelfServiceSettingsFlow](docs/Model/SelfServiceSettingsFlow.md)
- [SelfServiceSettingsFlowState](docs/Model/SelfServiceSettingsFlowState.md)
- [SelfServiceVerificationFlow](docs/Model/SelfServiceVerificationFlow.md)
- [SelfServiceVerificationFlowState](docs/Model/SelfServiceVerificationFlowState.md)
- [Session](docs/Model/Session.md)
- [SessionAuthenticationMethod](docs/Model/SessionAuthenticationMethod.md)
- [SessionDevice](docs/Model/SessionDevice.md)
- [SettingsProfileFormConfig](docs/Model/SettingsProfileFormConfig.md)
- [SourcePosition](docs/Model/SourcePosition.md)
- [StripeCustomerResponse](docs/Model/StripeCustomerResponse.md)
- [SubjectSet](docs/Model/SubjectSet.md)
- [SubmitSelfServiceFlowWithWebAuthnRegistrationMethod](docs/Model/SubmitSelfServiceFlowWithWebAuthnRegistrationMethod.md)
- [SubmitSelfServiceLoginFlowBody](docs/Model/SubmitSelfServiceLoginFlowBody.md)
- [SubmitSelfServiceLoginFlowWithLookupSecretMethodBody](docs/Model/SubmitSelfServiceLoginFlowWithLookupSecretMethodBody.md)
- [SubmitSelfServiceLoginFlowWithOidcMethodBody](docs/Model/SubmitSelfServiceLoginFlowWithOidcMethodBody.md)
- [SubmitSelfServiceLoginFlowWithPasswordMethodBody](docs/Model/SubmitSelfServiceLoginFlowWithPasswordMethodBody.md)
- [SubmitSelfServiceLoginFlowWithTotpMethodBody](docs/Model/SubmitSelfServiceLoginFlowWithTotpMethodBody.md)
- [SubmitSelfServiceLoginFlowWithWebAuthnMethodBody](docs/Model/SubmitSelfServiceLoginFlowWithWebAuthnMethodBody.md)
- [SubmitSelfServiceLogoutFlowWithoutBrowserBody](docs/Model/SubmitSelfServiceLogoutFlowWithoutBrowserBody.md)
- [SubmitSelfServiceRecoveryFlowBody](docs/Model/SubmitSelfServiceRecoveryFlowBody.md)
- [SubmitSelfServiceRecoveryFlowWithCodeMethodBody](docs/Model/SubmitSelfServiceRecoveryFlowWithCodeMethodBody.md)
- [SubmitSelfServiceRecoveryFlowWithLinkMethodBody](docs/Model/SubmitSelfServiceRecoveryFlowWithLinkMethodBody.md)
- [SubmitSelfServiceRegistrationFlowBody](docs/Model/SubmitSelfServiceRegistrationFlowBody.md)
- [SubmitSelfServiceRegistrationFlowWithOidcMethodBody](docs/Model/SubmitSelfServiceRegistrationFlowWithOidcMethodBody.md)
- [SubmitSelfServiceRegistrationFlowWithPasswordMethodBody](docs/Model/SubmitSelfServiceRegistrationFlowWithPasswordMethodBody.md)
- [SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody](docs/Model/SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody.md)
- [SubmitSelfServiceSettingsFlowBody](docs/Model/SubmitSelfServiceSettingsFlowBody.md)
- [SubmitSelfServiceSettingsFlowWithLookupMethodBody](docs/Model/SubmitSelfServiceSettingsFlowWithLookupMethodBody.md)
- [SubmitSelfServiceSettingsFlowWithOidcMethodBody](docs/Model/SubmitSelfServiceSettingsFlowWithOidcMethodBody.md)
- [SubmitSelfServiceSettingsFlowWithPasswordMethodBody](docs/Model/SubmitSelfServiceSettingsFlowWithPasswordMethodBody.md)
- [SubmitSelfServiceSettingsFlowWithProfileMethodBody](docs/Model/SubmitSelfServiceSettingsFlowWithProfileMethodBody.md)
- [SubmitSelfServiceSettingsFlowWithTotpMethodBody](docs/Model/SubmitSelfServiceSettingsFlowWithTotpMethodBody.md)
- [SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody](docs/Model/SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody.md)
- [SubmitSelfServiceVerificationFlowBody](docs/Model/SubmitSelfServiceVerificationFlowBody.md)
- [SubmitSelfServiceVerificationFlowWithLinkMethodBody](docs/Model/SubmitSelfServiceVerificationFlowWithLinkMethodBody.md)
- [Subscription](docs/Model/Subscription.md)
- [SuccessfulOAuth2RequestResponse](docs/Model/SuccessfulOAuth2RequestResponse.md)
- [SuccessfulProjectUpdate](docs/Model/SuccessfulProjectUpdate.md)
- [SuccessfulSelfServiceLoginWithoutBrowser](docs/Model/SuccessfulSelfServiceLoginWithoutBrowser.md)
- [SuccessfulSelfServiceRegistrationWithoutBrowser](docs/Model/SuccessfulSelfServiceRegistrationWithoutBrowser.md)
- [TokenPagination](docs/Model/TokenPagination.md)
- [TokenPaginationHeaders](docs/Model/TokenPaginationHeaders.md)
- [TrustedOAuth2JwtGrantIssuer](docs/Model/TrustedOAuth2JwtGrantIssuer.md)
- [TrustedOAuth2JwtGrantJsonWebKey](docs/Model/TrustedOAuth2JwtGrantJsonWebKey.md)
- [UiContainer](docs/Model/UiContainer.md)
- [UiNode](docs/Model/UiNode.md)
- [UiNodeAnchorAttributes](docs/Model/UiNodeAnchorAttributes.md)
- [UiNodeAttributes](docs/Model/UiNodeAttributes.md)
- [UiNodeImageAttributes](docs/Model/UiNodeImageAttributes.md)
- [UiNodeInputAttributes](docs/Model/UiNodeInputAttributes.md)
- [UiNodeMeta](docs/Model/UiNodeMeta.md)
- [UiNodeScriptAttributes](docs/Model/UiNodeScriptAttributes.md)
- [UiNodeTextAttributes](docs/Model/UiNodeTextAttributes.md)
- [UiText](docs/Model/UiText.md)
- [UpdateCustomHostnameBody](docs/Model/UpdateCustomHostnameBody.md)
- [UpdateOAuth2ClientLifespans](docs/Model/UpdateOAuth2ClientLifespans.md)
- [UpdateProject](docs/Model/UpdateProject.md)
- [UpdateSubscriptionPayload](docs/Model/UpdateSubscriptionPayload.md)
- [VerifiableIdentityAddress](docs/Model/VerifiableIdentityAddress.md)
- [Version](docs/Model/Version.md)
- [Warning](docs/Model/Warning.md)

## Authorization

### basic

- **Type**: HTTP basic authentication


### bearer

- **Type**: Bearer authentication


### oauth2

- **Type**: `OAuth`
- **Flow**: `accessCode`
- **Authorization URL**: `https://hydra.demo.ory.sh/oauth2/auth`
- **Scopes**: 
    - **offline**: A scope required when requesting refresh tokens (alias for `offline_access`)
    - **offline_access**: A scope required when requesting refresh tokens
    - **openid**: Request an OpenID Connect ID Token


### oryAccessToken

- **Type**: Bearer authentication

## Tests

To run the tests, use:

```bash
composer install
vendor/bin/phpunit
```

## Author

support@ory.sh

## About this package

This PHP package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: `v0.2.0-alpha.60`
- Build package: `org.openapitools.codegen.languages.PhpClientCodegen`
