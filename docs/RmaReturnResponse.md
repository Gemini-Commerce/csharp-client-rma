# # RmaReturnResponse


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id**| **string** |   | [optional]
**Grn**| **string** |   | [optional]
**OrderGrn**| **string** |   | [optional]
**Status**| **string** |   | [optional]
**Products**| [**List<RmaReturnProduct>**](RmaReturnProduct.md) |   | [optional]
**PreferredRefundMethod**| **RmaRefundMethod** |  for more information please, see Model/RmaRefundMethod.php  | [optional]
**RefundShippingCost**| **bool** |   | [optional]
**RefundPaymentCost**| **bool** |   | [optional]
**CustomerInfo**| [**RmaCustomerInfo**](RmaCustomerInfo.md) |   | [optional]
**ReturnAddress**| [**RmaPostalAddress**](RmaPostalAddress.md) |   | [optional]
**Note**| **string** |   | [optional]
**History**| [**List<RmaReturnHistory>**](RmaReturnHistory.md) |   | [optional]
**CreatedAt**| **DateTime** |   | [optional]
**UpdatedAt**| **DateTime** |   | [optional]
**OrderData**| [**RmaOrderData**](RmaOrderData.md) |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

