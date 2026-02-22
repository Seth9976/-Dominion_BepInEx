using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000071 RID: 113
	public class StoreConfiguration : Object
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x000154A4 File Offset: 0x000136A4
		// Note: this type is marked as 'beforefieldinit'.
		static StoreConfiguration()
		{
			Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "StoreConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr);
			StoreConfiguration.NativeFieldInfoPtr__androidStore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr, "<androidStore>k__BackingField");
			StoreConfiguration.NativeMethodInfoPtr_get_androidStore_Public_get_AppStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr, 100663869);
			StoreConfiguration.NativeMethodInfoPtr_set_androidStore_Private_set_Void_AppStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr, 100663870);
			StoreConfiguration.NativeMethodInfoPtr__ctor_Public_Void_AppStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr, 100663871);
			StoreConfiguration.NativeMethodInfoPtr_Deserialize_Public_Static_StoreConfiguration_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr, 100663872);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00015538 File Offset: 0x00013738
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00015574 File Offset: 0x00013774
		public unsafe AppStore androidStore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreConfiguration.NativeMethodInfoPtr_get_androidStore_Public_get_AppStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreConfiguration.NativeMethodInfoPtr_set_androidStore_Private_set_Void_AppStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000155B4 File Offset: 0x000137B4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoreConfiguration(AppStore store)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreConfiguration>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref store;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreConfiguration.NativeMethodInfoPtr__ctor_Public_Void_AppStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000155FC File Offset: 0x000137FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156206, RefRangeEnd = 156207, XrefRangeStart = 156167, XrefRangeEnd = 156206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StoreConfiguration Deserialize(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreConfiguration.NativeMethodInfoPtr_Deserialize_Public_Static_StoreConfiguration_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoreConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00004552 File Offset: 0x00002752
		public StoreConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00015640 File Offset: 0x00013840
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0000455B File Offset: 0x0000275B
		public unsafe AppStore _androidStore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreConfiguration.NativeFieldInfoPtr__androidStore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreConfiguration.NativeFieldInfoPtr__androidStore_k__BackingField)) = value;
			}
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr__androidStore_k__BackingField;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_get_androidStore_Public_get_AppStore_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_set_androidStore_Private_set_Void_AppStore_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AppStore_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_StoreConfiguration_String_0;
	}
}
