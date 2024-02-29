# rma.Api.RmaApi

All URIs are relative to *https://rma.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddNote**](RmaApi.md#addnote) | **POST** /rma.Rma/AddNote | Add a note to an RMA |
| [**ApproveReturn**](RmaApi.md#approvereturn) | **POST** /rma.Rma/ApproveReturn | Approve a return |
| [**CancelReturn**](RmaApi.md#cancelreturn) | **POST** /rma.Rma/CancelReturn | Cancel a return |
| [**ConfirmReturnApproveItems**](RmaApi.md#confirmreturnapproveitems) | **POST** /rma.Rma/ConfirmReturnApproveItems | Confirm return approve items |
| [**CreateReturn**](RmaApi.md#createreturn) | **POST** /rma.Rma/CreateReturn | Create a return |
| [**DeleteNote**](RmaApi.md#deletenote) | **POST** /rma.Rma/DeleteNote | Delete a note from an RMA |
| [**EditNote**](RmaApi.md#editnote) | **POST** /rma.Rma/EditNote | Edit a note on an RMA |
| [**GetReturn**](RmaApi.md#getreturn) | **POST** /rma.Rma/GetReturn | Get a return |
| [**ListNotesByReturnId**](RmaApi.md#listnotesbyreturnid) | **POST** /rma.Rma/ListNotesByReturnId | List notes by return id |
| [**ListReturns**](RmaApi.md#listreturns) | **POST** /rma.Rma/ListReturns | List returns |
| [**RefundReturn**](RmaApi.md#refundreturn) | **POST** /rma.Rma/RefundReturn | Refund a return |
| [**RejectReturn**](RmaApi.md#rejectreturn) | **POST** /rma.Rma/RejectReturn | Reject a return |
| [**SetReceivedItems**](RmaApi.md#setreceiveditems) | **POST** /rma.Rma/SetReceivedItems | Set received items |
| [**SkipReturnStatus**](RmaApi.md#skipreturnstatus) | **POST** /rma.Rma/SkipReturnStatus | Skip a return status |

<a id="addnote"></a>
# **AddNote**
> RmaNoteResponse AddNote (RmaAddNoteRequest body)

Add a note to an RMA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class AddNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaAddNoteRequest(); // RmaAddNoteRequest | 

            try
            {
                // Add a note to an RMA
                RmaNoteResponse result = apiInstance.AddNote(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.AddNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a note to an RMA
    ApiResponse<RmaNoteResponse> response = apiInstance.AddNoteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.AddNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaAddNoteRequest**](RmaAddNoteRequest.md) |  |  |

### Return type

[**RmaNoteResponse**](RmaNoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="approvereturn"></a>
# **ApproveReturn**
> RpcStatus ApproveReturn (RmaApproveReturnRequest body)

Approve a return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class ApproveReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaApproveReturnRequest(); // RmaApproveReturnRequest | 

            try
            {
                // Approve a return
                RpcStatus result = apiInstance.ApproveReturn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.ApproveReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApproveReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve a return
    ApiResponse<RpcStatus> response = apiInstance.ApproveReturnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.ApproveReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaApproveReturnRequest**](RmaApproveReturnRequest.md) |  |  |

### Return type

[**RpcStatus**](RpcStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelreturn"></a>
# **CancelReturn**
> Object CancelReturn (RmaCancelReturnRequest body)

Cancel a return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class CancelReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaCancelReturnRequest(); // RmaCancelReturnRequest | 

            try
            {
                // Cancel a return
                Object result = apiInstance.CancelReturn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.CancelReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel a return
    ApiResponse<Object> response = apiInstance.CancelReturnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.CancelReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaCancelReturnRequest**](RmaCancelReturnRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="confirmreturnapproveitems"></a>
# **ConfirmReturnApproveItems**
> Object ConfirmReturnApproveItems (RmaConfirmReturnApproveItemsRequest body)

Confirm return approve items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class ConfirmReturnApproveItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaConfirmReturnApproveItemsRequest(); // RmaConfirmReturnApproveItemsRequest | 

            try
            {
                // Confirm return approve items
                Object result = apiInstance.ConfirmReturnApproveItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.ConfirmReturnApproveItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmReturnApproveItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Confirm return approve items
    ApiResponse<Object> response = apiInstance.ConfirmReturnApproveItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.ConfirmReturnApproveItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaConfirmReturnApproveItemsRequest**](RmaConfirmReturnApproveItemsRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createreturn"></a>
# **CreateReturn**
> RmaReturnResponse CreateReturn (RmaCreateReturnRequest body)

Create a return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class CreateReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaCreateReturnRequest(); // RmaCreateReturnRequest | 

            try
            {
                // Create a return
                RmaReturnResponse result = apiInstance.CreateReturn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.CreateReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a return
    ApiResponse<RmaReturnResponse> response = apiInstance.CreateReturnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.CreateReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaCreateReturnRequest**](RmaCreateReturnRequest.md) |  |  |

### Return type

[**RmaReturnResponse**](RmaReturnResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletenote"></a>
# **DeleteNote**
> Object DeleteNote (RmaDeleteNoteRequest body)

Delete a note from an RMA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class DeleteNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaDeleteNoteRequest(); // RmaDeleteNoteRequest | 

            try
            {
                // Delete a note from an RMA
                Object result = apiInstance.DeleteNote(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.DeleteNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a note from an RMA
    ApiResponse<Object> response = apiInstance.DeleteNoteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.DeleteNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaDeleteNoteRequest**](RmaDeleteNoteRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editnote"></a>
# **EditNote**
> RmaNoteResponse EditNote (RmaEditNoteRequest body)

Edit a note on an RMA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class EditNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaEditNoteRequest(); // RmaEditNoteRequest | 

            try
            {
                // Edit a note on an RMA
                RmaNoteResponse result = apiInstance.EditNote(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.EditNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a note on an RMA
    ApiResponse<RmaNoteResponse> response = apiInstance.EditNoteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.EditNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaEditNoteRequest**](RmaEditNoteRequest.md) |  |  |

### Return type

[**RmaNoteResponse**](RmaNoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreturn"></a>
# **GetReturn**
> RmaReturnResponse GetReturn (RmaGetReturnRequest body)

Get a return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class GetReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaGetReturnRequest(); // RmaGetReturnRequest | 

            try
            {
                // Get a return
                RmaReturnResponse result = apiInstance.GetReturn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.GetReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a return
    ApiResponse<RmaReturnResponse> response = apiInstance.GetReturnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.GetReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaGetReturnRequest**](RmaGetReturnRequest.md) |  |  |

### Return type

[**RmaReturnResponse**](RmaReturnResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listnotesbyreturnid"></a>
# **ListNotesByReturnId**
> RmaListNotesByReturnIdResponse ListNotesByReturnId (RmaListNotesByReturnIdRequest body)

List notes by return id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class ListNotesByReturnIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaListNotesByReturnIdRequest(); // RmaListNotesByReturnIdRequest | 

            try
            {
                // List notes by return id
                RmaListNotesByReturnIdResponse result = apiInstance.ListNotesByReturnId(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.ListNotesByReturnId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNotesByReturnIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List notes by return id
    ApiResponse<RmaListNotesByReturnIdResponse> response = apiInstance.ListNotesByReturnIdWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.ListNotesByReturnIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaListNotesByReturnIdRequest**](RmaListNotesByReturnIdRequest.md) |  |  |

### Return type

[**RmaListNotesByReturnIdResponse**](RmaListNotesByReturnIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listreturns"></a>
# **ListReturns**
> RmaListReturnsResponse ListReturns (RmaListReturnsRequest body)

List returns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class ListReturnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaListReturnsRequest(); // RmaListReturnsRequest | 

            try
            {
                // List returns
                RmaListReturnsResponse result = apiInstance.ListReturns(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.ListReturns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List returns
    ApiResponse<RmaListReturnsResponse> response = apiInstance.ListReturnsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.ListReturnsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaListReturnsRequest**](RmaListReturnsRequest.md) |  |  |

### Return type

[**RmaListReturnsResponse**](RmaListReturnsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refundreturn"></a>
# **RefundReturn**
> Object RefundReturn (RmaRefundReturnRequest body)

Refund a return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class RefundReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaRefundReturnRequest(); // RmaRefundReturnRequest | 

            try
            {
                // Refund a return
                Object result = apiInstance.RefundReturn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.RefundReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefundReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refund a return
    ApiResponse<Object> response = apiInstance.RefundReturnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.RefundReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaRefundReturnRequest**](RmaRefundReturnRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rejectreturn"></a>
# **RejectReturn**
> Object RejectReturn (RmaRejectReturnRequest body)

Reject a return

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class RejectReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaRejectReturnRequest(); // RmaRejectReturnRequest | 

            try
            {
                // Reject a return
                Object result = apiInstance.RejectReturn(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.RejectReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RejectReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reject a return
    ApiResponse<Object> response = apiInstance.RejectReturnWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.RejectReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaRejectReturnRequest**](RmaRejectReturnRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setreceiveditems"></a>
# **SetReceivedItems**
> Object SetReceivedItems (RmaSetReceivedItemsRequest body)

Set received items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class SetReceivedItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaSetReceivedItemsRequest(); // RmaSetReceivedItemsRequest | 

            try
            {
                // Set received items
                Object result = apiInstance.SetReceivedItems(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.SetReceivedItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetReceivedItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set received items
    ApiResponse<Object> response = apiInstance.SetReceivedItemsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.SetReceivedItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaSetReceivedItemsRequest**](RmaSetReceivedItemsRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="skipreturnstatus"></a>
# **SkipReturnStatus**
> Object SkipReturnStatus (RmaSkipReturnStatusRequest body)

Skip a return status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rma.Api;
using rma.Client;
using rma.Model;

namespace Example
{
    public class SkipReturnStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rma.api.gogemini.io";

            var apiInstance = new RmaApi(config);
            var body = new RmaSkipReturnStatusRequest(); // RmaSkipReturnStatusRequest | 

            try
            {
                // Skip a return status
                Object result = apiInstance.SkipReturnStatus(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RmaApi.SkipReturnStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SkipReturnStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Skip a return status
    ApiResponse<Object> response = apiInstance.SkipReturnStatusWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RmaApi.SkipReturnStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**RmaSkipReturnStatusRequest**](RmaSkipReturnStatusRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

