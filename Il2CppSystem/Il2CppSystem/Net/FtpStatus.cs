using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000109 RID: 265
	public class FtpStatus : Object
	{
		// Token: 0x06000F92 RID: 3986 RVA: 0x0004B0D4 File Offset: 0x000492D4
		// Note: this type is marked as 'beforefieldinit'.
		static FtpStatus()
		{
			Il2CppClassPointerStore<FtpStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr);
			FtpStatus.NativeFieldInfoPtr_statusCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, "statusCode");
			FtpStatus.NativeFieldInfoPtr_statusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, "statusDescription");
			FtpStatus.NativeMethodInfoPtr__ctor_Public_Void_FtpStatusCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, 100665478);
			FtpStatus.NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, 100665479);
			FtpStatus.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr, 100665480);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0004B168 File Offset: 0x00049368
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 50515, RefRangeEnd = 50526, XrefRangeStart = 50514, XrefRangeEnd = 50515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpStatus(FtpStatusCode statusCode, string statusDescription)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpStatus>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpStatus.NativeMethodInfoPtr__ctor_Public_Void_FtpStatusCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0004B1C4 File Offset: 0x000493C4
		public unsafe FtpStatusCode StatusCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpStatus.NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0004B200 File Offset: 0x00049400
		public unsafe string StatusDescription
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpStatus.NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00008203 File Offset: 0x00006403
		public FtpStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x0004B238 File Offset: 0x00049438
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x0000820C File Offset: 0x0000640C
		public unsafe FtpStatusCode statusCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusCode)) = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x0004B260 File Offset: 0x00049460
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00008227 File Offset: 0x00006427
		public unsafe string statusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FtpStatus.NativeFieldInfoPtr_statusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_statusCode;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr_statusDescription;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FtpStatusCode_String_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_FtpStatusCode_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusDescription_Public_get_String_0;
	}
}
