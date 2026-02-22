using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000110 RID: 272
	public sealed class IPv6AddressFormatter : ValueType
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x00050808 File Offset: 0x0004EA08
		// Note: this type is marked as 'beforefieldinit'.
		static IPv6AddressFormatter()
		{
			Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPv6AddressFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr);
			IPv6AddressFormatter.NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, "address");
			IPv6AddressFormatter.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, "scopeId");
			IPv6AddressFormatter.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665665);
			IPv6AddressFormatter.NativeMethodInfoPtr_SwapUShort_Private_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665666);
			IPv6AddressFormatter.NativeMethodInfoPtr_AsIPv4Int_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665667);
			IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Compatible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665668);
			IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Mapped_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665669);
			IPv6AddressFormatter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr, 100665670);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000508D8 File Offset: 0x0004EAD8
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 52612, RefRangeEnd = 52647, XrefRangeStart = 52612, XrefRangeEnd = 52612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPv6AddressFormatter(Il2CppStructArray<ushort> addr, long scopeId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt16_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00050938 File Offset: 0x0004EB38
		[CallerCount(0)]
		public unsafe static ushort SwapUShort(ushort number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_SwapUShort_Private_Static_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00050978 File Offset: 0x0004EB78
		[CallerCount(0)]
		public unsafe uint AsIPv4Int()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_AsIPv4Int_Private_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000509BC File Offset: 0x0004EBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52647, RefRangeEnd = 52648, XrefRangeStart = 52647, XrefRangeEnd = 52647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIPv4Compatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Compatible_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00050A00 File Offset: 0x0004EC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52648, RefRangeEnd = 52650, XrefRangeStart = 52648, XrefRangeEnd = 52648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIPv4Mapped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_IsIPv4Mapped_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00050A44 File Offset: 0x0004EC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52693, RefRangeEnd = 52694, XrefRangeStart = 52650, XrefRangeEnd = 52693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPv6AddressFormatter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00008EEC File Offset: 0x000070EC
		public IPv6AddressFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00008EF5 File Offset: 0x000070F5
		public IPv6AddressFormatter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPv6AddressFormatter>.NativeClassPtr))
		{
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00050A80 File Offset: 0x0004EC80
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x00008F07 File Offset: 0x00007107
		public unsafe Il2CppStructArray<ushort> address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00050AB0 File Offset: 0x0004ECB0
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x00008F26 File Offset: 0x00007126
		public unsafe long scopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_scopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPv6AddressFormatter.NativeFieldInfoPtr_scopeId)) = value;
			}
		}

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeFieldInfoPtr_address;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeFieldInfoPtr_scopeId;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt16_Int64_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_SwapUShort_Private_Static_UInt16_UInt16_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_AsIPv4Int_Private_UInt32_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_IsIPv4Compatible_Private_Boolean_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_IsIPv4Mapped_Private_Boolean_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
