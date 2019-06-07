# IO.Swagger.Model.DetectInvoiceResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentResolution** | **int?** | Resolution of the original document in dpi. | [optional] 
**Language** | **string** | Resolution of the original document in dpi. | [optional] 
**InvoiceDetailTypePredictions** | [**List&lt;DetectionResponse&gt;**](DetectionResponse.md) | List of Predictions - One for each predicted invoice detail. | [optional] 
**PredictionGroups** | [**List&lt;DetectionGroupResponse&gt;**](DetectionGroupResponse.md) | List of PredictionGroups - One for each predicted invoice detail&lt;br&gt;e.g. VatGroup, containing predictions for Vat Rate, Net Amount and Vat Amount | [optional] 
**LineItems** | [**List&lt;LineItemGroupResponse&gt;**](LineItemGroupResponse.md) | List of predicted line items | [optional] 
**Sender** | [**ContactResponse**](ContactResponse.md) | The sender of the invoice | [optional] 
**FormattedResult** | **string** | Special invoice format. (for future use only) | [optional] 
**IsQualityOk** | **bool?** | Invoice quality flag. (for future use only) | [optional] 
**OcrResult** | **string** | OCR-result as json string | [optional] 
**ResultPdf** | **string** | Result pdf-document with marked predictions. (encoded as base64 string) | [optional] 
**InvoiceState** | **int?** | Describes the state of the processed invoice. 0 &#x3D; Ok | [optional] 
**Measurements** | [**DictionaryStringInt64**](DictionaryStringInt64.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

