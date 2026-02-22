using System;

namespace Steamworks
{
	// Token: 0x0200029C RID: 668
	public enum EHTTPStatusCode
	{
		// Token: 0x0400258C RID: 9612
		k_EHTTPStatusCodeInvalid,
		// Token: 0x0400258D RID: 9613
		k_EHTTPStatusCode100Continue = 100,
		// Token: 0x0400258E RID: 9614
		k_EHTTPStatusCode101SwitchingProtocols,
		// Token: 0x0400258F RID: 9615
		k_EHTTPStatusCode200OK = 200,
		// Token: 0x04002590 RID: 9616
		k_EHTTPStatusCode201Created,
		// Token: 0x04002591 RID: 9617
		k_EHTTPStatusCode202Accepted,
		// Token: 0x04002592 RID: 9618
		k_EHTTPStatusCode203NonAuthoritative,
		// Token: 0x04002593 RID: 9619
		k_EHTTPStatusCode204NoContent,
		// Token: 0x04002594 RID: 9620
		k_EHTTPStatusCode205ResetContent,
		// Token: 0x04002595 RID: 9621
		k_EHTTPStatusCode206PartialContent,
		// Token: 0x04002596 RID: 9622
		k_EHTTPStatusCode300MultipleChoices = 300,
		// Token: 0x04002597 RID: 9623
		k_EHTTPStatusCode301MovedPermanently,
		// Token: 0x04002598 RID: 9624
		k_EHTTPStatusCode302Found,
		// Token: 0x04002599 RID: 9625
		k_EHTTPStatusCode303SeeOther,
		// Token: 0x0400259A RID: 9626
		k_EHTTPStatusCode304NotModified,
		// Token: 0x0400259B RID: 9627
		k_EHTTPStatusCode305UseProxy,
		// Token: 0x0400259C RID: 9628
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		// Token: 0x0400259D RID: 9629
		k_EHTTPStatusCode400BadRequest = 400,
		// Token: 0x0400259E RID: 9630
		k_EHTTPStatusCode401Unauthorized,
		// Token: 0x0400259F RID: 9631
		k_EHTTPStatusCode402PaymentRequired,
		// Token: 0x040025A0 RID: 9632
		k_EHTTPStatusCode403Forbidden,
		// Token: 0x040025A1 RID: 9633
		k_EHTTPStatusCode404NotFound,
		// Token: 0x040025A2 RID: 9634
		k_EHTTPStatusCode405MethodNotAllowed,
		// Token: 0x040025A3 RID: 9635
		k_EHTTPStatusCode406NotAcceptable,
		// Token: 0x040025A4 RID: 9636
		k_EHTTPStatusCode407ProxyAuthRequired,
		// Token: 0x040025A5 RID: 9637
		k_EHTTPStatusCode408RequestTimeout,
		// Token: 0x040025A6 RID: 9638
		k_EHTTPStatusCode409Conflict,
		// Token: 0x040025A7 RID: 9639
		k_EHTTPStatusCode410Gone,
		// Token: 0x040025A8 RID: 9640
		k_EHTTPStatusCode411LengthRequired,
		// Token: 0x040025A9 RID: 9641
		k_EHTTPStatusCode412PreconditionFailed,
		// Token: 0x040025AA RID: 9642
		k_EHTTPStatusCode413RequestEntityTooLarge,
		// Token: 0x040025AB RID: 9643
		k_EHTTPStatusCode414RequestURITooLong,
		// Token: 0x040025AC RID: 9644
		k_EHTTPStatusCode415UnsupportedMediaType,
		// Token: 0x040025AD RID: 9645
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable,
		// Token: 0x040025AE RID: 9646
		k_EHTTPStatusCode417ExpectationFailed,
		// Token: 0x040025AF RID: 9647
		k_EHTTPStatusCode4xxUnknown,
		// Token: 0x040025B0 RID: 9648
		k_EHTTPStatusCode429TooManyRequests = 429,
		// Token: 0x040025B1 RID: 9649
		k_EHTTPStatusCode444ConnectionClosed = 444,
		// Token: 0x040025B2 RID: 9650
		k_EHTTPStatusCode500InternalServerError = 500,
		// Token: 0x040025B3 RID: 9651
		k_EHTTPStatusCode501NotImplemented,
		// Token: 0x040025B4 RID: 9652
		k_EHTTPStatusCode502BadGateway,
		// Token: 0x040025B5 RID: 9653
		k_EHTTPStatusCode503ServiceUnavailable,
		// Token: 0x040025B6 RID: 9654
		k_EHTTPStatusCode504GatewayTimeout,
		// Token: 0x040025B7 RID: 9655
		k_EHTTPStatusCode505HTTPVersionNotSupported,
		// Token: 0x040025B8 RID: 9656
		k_EHTTPStatusCode5xxUnknown = 599
	}
}
