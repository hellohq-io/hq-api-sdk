# HQ.API.SDK.Model.CustomFieldDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of this customfield definition | 
**Description** | **string** | The description of this customfield definition | [optional] 
**Order** | **int?** | The display order of this customfield definition | [optional] 
**RightLevelRead** | **int?** | The required right level to read this customfield | [optional] 
**RightLevelWrite** | **int?** | The required right level to write this customfield | [optional] 
**IsRequired** | **bool?** | Whether this is a required field | [optional] 
**TypeText** | **string** | The textual representation of the type | 
**Category** | **int?** | The textual representation of the category | [optional] 
**Options** | [**List&lt;CustomFieldOption&gt;**](CustomFieldOption.md) | A list of selectable options for customfields of multi-select types | [optional] 
**Id** | **int?** | The unique identifier of this entity | [optional] 
**CreatedBy** | **int?** | The id of the user who created this entity | [optional] 
**UpdatedBy** | **int?** | The id of the last user who modified this entity | [optional] 
**CreatedOn** | **DateTime?** | The date and time this entity was created, in UTC | [optional] 
**UpdatedOn** | **DateTime?** | The last date and time this entity was updated, in UTC | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

