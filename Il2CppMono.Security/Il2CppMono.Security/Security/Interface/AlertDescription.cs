using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000019 RID: 25
	[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "AlertDescription")]
	public enum AlertDescription : byte
	{
		// Token: 0x04000103 RID: 259
		CloseNotify,
		// Token: 0x04000104 RID: 260
		UnexpectedMessage = 10,
		// Token: 0x04000105 RID: 261
		BadRecordMAC = 20,
		// Token: 0x04000106 RID: 262
		DecryptionFailed_RESERVED,
		// Token: 0x04000107 RID: 263
		RecordOverflow,
		// Token: 0x04000108 RID: 264
		DecompressionFailure = 30,
		// Token: 0x04000109 RID: 265
		HandshakeFailure = 40,
		// Token: 0x0400010A RID: 266
		NoCertificate_RESERVED,
		// Token: 0x0400010B RID: 267
		BadCertificate,
		// Token: 0x0400010C RID: 268
		UnsupportedCertificate,
		// Token: 0x0400010D RID: 269
		CertificateRevoked,
		// Token: 0x0400010E RID: 270
		CertificateExpired,
		// Token: 0x0400010F RID: 271
		CertificateUnknown,
		// Token: 0x04000110 RID: 272
		IlegalParameter,
		// Token: 0x04000111 RID: 273
		UnknownCA,
		// Token: 0x04000112 RID: 274
		AccessDenied,
		// Token: 0x04000113 RID: 275
		DecodeError,
		// Token: 0x04000114 RID: 276
		DecryptError,
		// Token: 0x04000115 RID: 277
		ExportRestriction = 60,
		// Token: 0x04000116 RID: 278
		ProtocolVersion = 70,
		// Token: 0x04000117 RID: 279
		InsuficientSecurity,
		// Token: 0x04000118 RID: 280
		InternalError = 80,
		// Token: 0x04000119 RID: 281
		UserCancelled = 90,
		// Token: 0x0400011A RID: 282
		NoRenegotiation = 100,
		// Token: 0x0400011B RID: 283
		UnsupportedExtension = 110
	}
}
