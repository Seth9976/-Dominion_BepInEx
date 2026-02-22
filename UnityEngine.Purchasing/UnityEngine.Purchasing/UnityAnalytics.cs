using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001B RID: 27
	public class UnityAnalytics : Object
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00006BAC File Offset: 0x00004DAC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAnalytics()
		{
			Il2CppClassPointerStore<UnityAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "UnityAnalytics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityAnalytics>.NativeClassPtr);
			UnityAnalytics.NativeMethodInfoPtr_Transaction_Public_Virtual_Final_New_Void_String_Decimal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAnalytics>.NativeClassPtr, 100663434);
			UnityAnalytics.NativeMethodInfoPtr_CustomEvent_Public_Virtual_Final_New_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAnalytics>.NativeClassPtr, 100663435);
			UnityAnalytics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAnalytics>.NativeClassPtr, 100663436);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00006C18 File Offset: 0x00004E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131182, XrefRangeEnd = 131183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Transaction(string productId, Decimal price, string currency, string receipt, string signature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAnalytics.NativeMethodInfoPtr_Transaction_Public_Virtual_Final_New_Void_String_Decimal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00006CA0 File Offset: 0x00004EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131183, XrefRangeEnd = 131184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CustomEvent(string name, Dictionary<string, Object> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAnalytics.NativeMethodInfoPtr_CustomEvent_Public_Virtual_Final_New_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00006CF4 File Offset: 0x00004EF4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAnalytics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAnalytics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAnalytics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002794 File Offset: 0x00000994
		public UnityAnalytics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_Transaction_Public_Virtual_Final_New_Void_String_Decimal_String_String_String_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_CustomEvent_Public_Virtual_Final_New_Void_String_Dictionary_2_String_Object_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
