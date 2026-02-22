using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009A RID: 154
	public class X509Extension : AsnEncodedData
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x000320D0 File Offset: 0x000302D0
		// Note: this type is marked as 'beforefieldinit'.
		static X509Extension()
		{
			Il2CppClassPointerStore<X509Extension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Extension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Extension>.NativeClassPtr);
			X509Extension.NativeFieldInfoPtr__critical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, "_critical");
			X509Extension.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100664482);
			X509Extension.NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100664483);
			X509Extension.NativeMethodInfoPtr_set_Critical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100664484);
			X509Extension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100664485);
			X509Extension.NativeMethodInfoPtr_FormatUnkownData_Internal_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Extension>.NativeClassPtr, 100664486);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00032178 File Offset: 0x00030378
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Extension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Extension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000321B4 File Offset: 0x000303B4
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x000321F0 File Offset: 0x000303F0
		public unsafe bool Critical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_set_Critical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00032230 File Offset: 0x00030430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42832, XrefRangeEnd = 42835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asnEncodedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Extension.NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00032280 File Offset: 0x00030480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42835, XrefRangeEnd = 42846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatUnkownData(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Extension.NativeMethodInfoPtr_FormatUnkownData_Internal_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00005BF1 File Offset: 0x00003DF1
		public X509Extension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x000322C8 File Offset: 0x000304C8
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00005BFA File Offset: 0x00003DFA
		public unsafe bool _critical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr__critical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Extension.NativeFieldInfoPtr__critical)) = value;
			}
		}

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr__critical;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_get_Critical_Public_get_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_set_Critical_Public_set_Void_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Virtual_Void_AsnEncodedData_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_FormatUnkownData_Internal_String_Il2CppStructArray_1_Byte_0;
	}
}
