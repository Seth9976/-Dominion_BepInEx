using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class UnifiedReceipt : Object
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00006A78 File Offset: 0x00004C78
		// Note: this type is marked as 'beforefieldinit'.
		static UnifiedReceipt()
		{
			Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "UnifiedReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr);
			UnifiedReceipt.NativeFieldInfoPtr_Payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr, "Payload");
			UnifiedReceipt.NativeFieldInfoPtr_Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr, "Store");
			UnifiedReceipt.NativeFieldInfoPtr_TransactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr, "TransactionID");
			UnifiedReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr, 100663433);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnifiedReceipt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnifiedReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnifiedReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000272E File Offset: 0x0000092E
		public UnifiedReceipt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00006B34 File Offset: 0x00004D34
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002737 File Offset: 0x00000937
		public unsafe string Payload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnifiedReceipt.NativeFieldInfoPtr_Payload);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnifiedReceipt.NativeFieldInfoPtr_Payload), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006B5C File Offset: 0x00004D5C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002756 File Offset: 0x00000956
		public unsafe string Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnifiedReceipt.NativeFieldInfoPtr_Store);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnifiedReceipt.NativeFieldInfoPtr_Store), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006B84 File Offset: 0x00004D84
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002775 File Offset: 0x00000975
		public unsafe string TransactionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnifiedReceipt.NativeFieldInfoPtr_TransactionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnifiedReceipt.NativeFieldInfoPtr_TransactionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_Payload;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr_Store;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_TransactionID;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
