using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038C RID: 908
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		// Token: 0x06003B2B RID: 15147 RVA: 0x00117AC4 File Offset: 0x00115CC4
		// Note: this type is marked as 'beforefieldinit'.
		static ActivatedServiceTypeEntry()
		{
			Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ActivatedServiceTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr);
			ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, "obj_type");
			ActivatedServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100672050);
			ActivatedServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100672051);
			ActivatedServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr, 100672052);
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00117B44 File Offset: 0x00115D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348763, RefRangeEnd = 348765, XrefRangeStart = 348757, XrefRangeEnd = 348763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivatedServiceTypeEntry(string typeName, string assemblyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivatedServiceTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00117BA4 File Offset: 0x00115DA4
		public unsafe Type ObjectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00117BE4 File Offset: 0x00115DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348765, XrefRangeEnd = 348766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivatedServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00016438 File Offset: 0x00014638
		public ActivatedServiceTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x00117C28 File Offset: 0x00115E28
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x00016441 File Offset: 0x00014641
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedServiceTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
