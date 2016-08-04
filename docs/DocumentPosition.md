# HQ.API.SDK.Model.DocumentPosition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsOptional** | **bool?** | Whether this position is optional. Only valid in quotations. | [optional] 
**Text** | **string** | The position text, as HTML | [optional] 
**Unit** | **string** | The position unit | [optional] 
**Tax** | **double?** | The position tax rate, for example 19% | [optional] 
**Price** | **decimal?** | The position price, in the currency of the document | [optional] 
**Discount** | **double?** | The percentage discount that should be applied to this position sum | [optional] 
**Margin** | **double?** | The margin thaqt should be applied to this position sum | [optional] 
**Type** | **int?** | The type of this position | [optional] 
**Order** | **int?** | The order of this position in the document | [optional] 
**ArticleId** | **int?** | The Id of the article that is associted with this position | [optional] 
**Article** | [**Article**](Article.md) |  | [optional] 
**Amount** | **double?** | The amount of this position in this document | [optional] 
**BookingAccount** | **string** | The booking account this position is associated with | [optional] 
**CostCenter1** | **string** | The cost center 1 this position is associated with | [optional] 
**CostCenter2** | **string** | The cost center 2 this position is associated with | [optional] 
**ExcludeFromEarlyPayment** | **bool?** | Whether this position should be excluded from early payment calculations | [optional] 
**Id** | **int?** | The unique identifier of this entity | [optional] 
**CreatedBy** | **int?** | The id of the user who created this entity | [optional] 
**UpdatedBy** | **int?** | The id of the last user who modified this entity | [optional] 
**CreatedOn** | **DateTime?** | The date and time this entity was created, in UTC | [optional] 
**UpdatedOn** | **DateTime?** | The last date and time this entity was updated, in UTC | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

