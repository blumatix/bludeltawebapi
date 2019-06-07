# IO.Swagger.Model.DetectionResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **int?** | Predicted invoice detail | 
**TypeName** | **string** | Predicted invoice detail | 
**Value** | **string** | Predicted value &lt;br&gt;&lt;br&gt;Formats:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GrandTotalAmount: decimal separator &#39;.&#39;, no group separator, two decimal digits, e.g. 9.00, 2314.50, -12.99&lt;/li&gt;&lt;li&gt;NetAmount: decimal separator &#39;.&#39;, no group separator, two decimal digits, e.g. 9.00, 2314.50, -12.99&lt;/li&gt;&lt;li&gt;VatAmount: decimal separator &#39;.&#39;, no group separator, two decimal digits, e.g. 9.00, 2314.50, -12.99&lt;/li&gt;&lt;li&gt;VatRate: decimal separator &#39;.&#39;, no group separator, one decimal digits, e.g. 20.0, 19.0, 10.0&lt;/li&gt;&lt;li&gt;InvoiceDate: YYYY-MM-DD (ISO 8601)&lt;/li&gt;&lt;li&gt;DeliveryDate: YYYY-MM-DD (ISO 8601)&lt;/li&gt;&lt;li&gt;SenderOrderDate: YYYY-MM-DD (ISO 8601)&lt;/li&gt;&lt;li&gt;ReceiverOrderDate: YYYY-MM-DD (ISO 8601)&lt;/li&gt;&lt;li&gt;InvoiceId: string&lt;/li&gt;&lt;li&gt;InvoiceId: string&lt;/li&gt;&lt;li&gt;CustomerId: string&lt;/li&gt;&lt;li&gt;SenderOrderId: string&lt;/li&gt;&lt;li&gt;ReceiverOrderId: string&lt;/li&gt;&lt;li&gt;DocumentType: &#39;Invoice&#39; or &#39;CreditMemo&#39;&lt;/li&gt;&lt;li&gt;Ibans: string without blanks, comma separated&lt;/li&gt;&lt;li&gt;UstIds: string without blanks, comma separated&lt;/li&gt;&lt;/ul&gt; | 
**Score** | **double?** | Scored probability. Value between zero and one. | 
**X** | **int?** | X-Position according to the document resolution | 
**Y** | **int?** | Y-Position according to the document resolution | 
**Width** | **int?** | Width according to the document resolution | 
**Height** | **int?** | Height according to the document resolution | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

