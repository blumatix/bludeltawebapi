# C# client for the BludeltaWebServiceAPI 

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [CommandLineParser](https://www.nuget.org/packages/CommandLineParser/) - 1.9.71

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="getting-started"></a>
## Getting Started

```csharp

```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://bludelta-alpha.azurewebsites.net*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressResponse](docs/AddressResponse.md)
 - [Model.ApiIdentifier](docs/ApiIdentifier.md)
 - [Model.ApiKey](docs/ApiKey.md)
 - [Model.AutoprocessedInvoiceContainerRequest](docs/AutoprocessedInvoiceContainerRequest.md)
 - [Model.ContactResponse](docs/ContactResponse.md)
 - [Model.DetailResponse](docs/DetailResponse.md)
 - [Model.DetectInvoiceResponse](docs/DetectInvoiceResponse.md)
 - [Model.DetectionGroupResponse](docs/DetectionGroupResponse.md)
 - [Model.DetectionResponse](docs/DetectionResponse.md)
 - [Model.DictionaryStringInt64](docs/DictionaryStringInt64.md)
 - [Model.ImageRequest](docs/ImageRequest.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.InvoiceContainer](docs/InvoiceContainer.md)
 - [Model.InvoiceContainerKeepAliveLockRequest](docs/InvoiceContainerKeepAliveLockRequest.md)
 - [Model.InvoiceContainerKeepAliveLockResponse](docs/InvoiceContainerKeepAliveLockResponse.md)
 - [Model.InvoiceContainerLockRequest](docs/InvoiceContainerLockRequest.md)
 - [Model.InvoiceContainerLockResponse](docs/InvoiceContainerLockResponse.md)
 - [Model.InvoiceContainerRequest](docs/InvoiceContainerRequest.md)
 - [Model.InvoiceContainerResponse](docs/InvoiceContainerResponse.md)
 - [Model.InvoiceContainerSaveRequest](docs/InvoiceContainerSaveRequest.md)
 - [Model.InvoiceContainerSaveResponse](docs/InvoiceContainerSaveResponse.md)
 - [Model.InvoiceContainerUnlockRequest](docs/InvoiceContainerUnlockRequest.md)
 - [Model.InvoiceContainerUnlockResponse](docs/InvoiceContainerUnlockResponse.md)
 - [Model.InvoiceContainersResponse](docs/InvoiceContainersResponse.md)
 - [Model.LineItemGroupResponse](docs/LineItemGroupResponse.md)
 - [Model.MandatorRequest](docs/MandatorRequest.md)
 - [Model.MandatorResponse](docs/MandatorResponse.md)
 - [Model.ModelObject](docs/ModelObject.md)
 - [Model.NeedForActionInvoiceContainerRequest](docs/NeedForActionInvoiceContainerRequest.md)
 - [Model.OcrResultRequest](docs/OcrResultRequest.md)
 - [Model.OcrResultResponse](docs/OcrResultResponse.md)
 - [Model.Page](docs/Page.md)
 - [Model.ReleasableInvoice](docs/ReleasableInvoice.md)
 - [Model.ReleasableInvoiceRequest](docs/ReleasableInvoiceRequest.md)
 - [Model.ReleasableInvoiceResponse](docs/ReleasableInvoiceResponse.md)
 - [Model.ReleaseInvoiceRequest](docs/ReleaseInvoiceRequest.md)
 - [Model.ReleaseInvoiceResponse](docs/ReleaseInvoiceResponse.md)
 - [Model.SaveInvoiceRequest](docs/SaveInvoiceRequest.md)
 - [Model.SaveInvoiceResponse](docs/SaveInvoiceResponse.md)
 - [Model.UploadInvoiceContainerRequest](docs/UploadInvoiceContainerRequest.md)
 - [Model.UploadInvoiceContainerResponse](docs/UploadInvoiceContainerResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="basic"></a>
### basic

- **Type**: HTTP basic authentication
