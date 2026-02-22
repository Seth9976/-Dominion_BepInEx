using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000028 RID: 40
	public class PurchaseFailureDescription : Object
	{
		// Token: 0x06000168 RID: 360 RVA: 0x000081B8 File Offset: 0x000063B8
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseFailureDescription()
		{
			Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "PurchaseFailureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr);
			PurchaseFailureDescription.NativeFieldInfoPtr__productId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, "<productId>k__BackingField");
			PurchaseFailureDescription.NativeFieldInfoPtr__reason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, "<reason>k__BackingField");
			PurchaseFailureDescription.NativeFieldInfoPtr__message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, "<message>k__BackingField");
			PurchaseFailureDescription.NativeMethodInfoPtr__ctor_Public_Void_String_PurchaseFailureReason_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663484);
			PurchaseFailureDescription.NativeMethodInfoPtr_get_productId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663485);
			PurchaseFailureDescription.NativeMethodInfoPtr_set_productId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663486);
			PurchaseFailureDescription.NativeMethodInfoPtr_get_reason_Public_get_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663487);
			PurchaseFailureDescription.NativeMethodInfoPtr_set_reason_Private_set_Void_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663488);
			PurchaseFailureDescription.NativeMethodInfoPtr_get_message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663489);
			PurchaseFailureDescription.NativeMethodInfoPtr_set_message_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr, 100663490);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000082B0 File Offset: 0x000064B0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 16496, RefRangeEnd = 16509, XrefRangeStart = 16496, XrefRangeEnd = 16509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseFailureDescription(string productId, PurchaseFailureReason reason, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseFailureDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr__ctor_Public_Void_String_PurchaseFailureReason_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000831C File Offset: 0x0000651C
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00008354 File Offset: 0x00006554
		public unsafe string productId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr_get_productId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr_set_productId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00008398 File Offset: 0x00006598
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000083D4 File Offset: 0x000065D4
		public unsafe PurchaseFailureReason reason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr_get_reason_Public_get_PurchaseFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr_set_reason_Private_set_Void_PurchaseFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00008414 File Offset: 0x00006614
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000844C File Offset: 0x0000664C
		public unsafe string message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr_get_message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseFailureDescription.NativeMethodInfoPtr_set_message_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000029AA File Offset: 0x00000BAA
		public PurchaseFailureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00008490 File Offset: 0x00006690
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000029B3 File Offset: 0x00000BB3
		public unsafe string _productId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailureDescription.NativeFieldInfoPtr__productId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailureDescription.NativeFieldInfoPtr__productId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000084B8 File Offset: 0x000066B8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000029D2 File Offset: 0x00000BD2
		public unsafe PurchaseFailureReason _reason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailureDescription.NativeFieldInfoPtr__reason_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailureDescription.NativeFieldInfoPtr__reason_k__BackingField)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000084E0 File Offset: 0x000066E0
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe string _message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailureDescription.NativeFieldInfoPtr__message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseFailureDescription.NativeFieldInfoPtr__message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr__productId_k__BackingField;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr__reason_k__BackingField;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr__message_k__BackingField;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PurchaseFailureReason_String_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_productId_Public_get_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_set_productId_Private_set_Void_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_reason_Public_get_PurchaseFailureReason_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_set_reason_Private_set_Void_PurchaseFailureReason_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_message_Public_get_String_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_set_message_Private_set_Void_String_0;
	}
}
