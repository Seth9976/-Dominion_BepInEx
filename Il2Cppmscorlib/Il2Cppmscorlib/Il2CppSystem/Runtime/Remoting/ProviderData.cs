using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000398 RID: 920
	public class ProviderData : Object
	{
		// Token: 0x06003C00 RID: 15360 RVA: 0x0011A9A8 File Offset: 0x00118BA8
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderData()
		{
			Il2CppClassPointerStore<ProviderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ProviderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderData>.NativeClassPtr);
			ProviderData.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Ref");
			ProviderData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Type");
			ProviderData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "Id");
			ProviderData.NativeFieldInfoPtr_CustomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "CustomProperties");
			ProviderData.NativeFieldInfoPtr_CustomData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, "CustomData");
			ProviderData.NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, 100672147);
			ProviderData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderData>.NativeClassPtr, 100672148);
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x0011AA64 File Offset: 0x00118C64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 350226, RefRangeEnd = 350230, XrefRangeStart = 350183, XrefRangeEnd = 350226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ProviderData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderData.NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x0011AAA8 File Offset: 0x00118CA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 350235, RefRangeEnd = 350239, XrefRangeStart = 350230, XrefRangeEnd = 350235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x000169D6 File Offset: 0x00014BD6
		public ProviderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x0011AAE4 File Offset: 0x00118CE4
		// (set) Token: 0x06003C05 RID: 15365 RVA: 0x000169DF File Offset: 0x00014BDF
		public unsafe string Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Ref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Ref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06003C06 RID: 15366 RVA: 0x0011AB0C File Offset: 0x00118D0C
		// (set) Token: 0x06003C07 RID: 15367 RVA: 0x000169FE File Offset: 0x00014BFE
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x0011AB34 File Offset: 0x00118D34
		// (set) Token: 0x06003C09 RID: 15369 RVA: 0x00016A1D File Offset: 0x00014C1D
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x0011AB5C File Offset: 0x00118D5C
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x00016A3C File Offset: 0x00014C3C
		public unsafe Hashtable CustomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06003C0C RID: 15372 RVA: 0x0011AB8C File Offset: 0x00118D8C
		// (set) Token: 0x06003C0D RID: 15373 RVA: 0x00016A5B File Offset: 0x00014C5B
		public unsafe IList CustomData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderData.NativeFieldInfoPtr_CustomData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeFieldInfoPtr_CustomProperties;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeFieldInfoPtr_CustomData;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ProviderData_0;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
