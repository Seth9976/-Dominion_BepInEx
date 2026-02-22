using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x0200001F RID: 31
	public static class ASN1Convert : Object
	{
		// Token: 0x060001CB RID: 459 RVA: 0x0002970C File Offset: 0x0002790C
		// Note: this type is marked as 'beforefieldinit'.
		static ASN1Convert()
		{
			Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "ASN1Convert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr);
			ASN1Convert.NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663524);
			ASN1Convert.NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663525);
			ASN1Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663526);
			ASN1Convert.NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663527);
			ASN1Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663528);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000297A0 File Offset: 0x000279A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260349, RefRangeEnd = 260351, XrefRangeStart = 260321, XrefRangeEnd = 260349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000297E0 File Offset: 0x000279E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 260356, RefRangeEnd = 260364, XrefRangeStart = 260351, XrefRangeEnd = 260356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ASN1 FromOid(string oid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00029824 File Offset: 0x00027A24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260370, RefRangeEnd = 260373, XrefRangeStart = 260364, XrefRangeEnd = 260370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ASN1 asn1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00029868 File Offset: 0x00027A68
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 260398, RefRangeEnd = 260411, XrefRangeStart = 260373, XrefRangeEnd = 260398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToOid(ASN1 asn1)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000298A4 File Offset: 0x00027AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260431, RefRangeEnd = 260433, XrefRangeStart = 260411, XrefRangeEnd = 260431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(ASN1 time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(time);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASN1Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002BCD File Offset: 0x00000DCD
		public ASN1Convert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0;
	}
}
