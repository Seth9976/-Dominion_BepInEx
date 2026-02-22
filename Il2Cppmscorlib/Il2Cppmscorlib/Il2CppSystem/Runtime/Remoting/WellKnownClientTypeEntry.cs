using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A4 RID: 932
	public class WellKnownClientTypeEntry : TypeEntry
	{
		// Token: 0x06003CB9 RID: 15545 RVA: 0x0011D9A0 File Offset: 0x0011BBA0
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownClientTypeEntry()
		{
			Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "WellKnownClientTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr);
			WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "obj_type");
			WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "obj_url");
			WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, "app_url");
			WellKnownClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672250);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672251);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672252);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672253);
			WellKnownClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr, 100672254);
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x0011DA70 File Offset: 0x0011BC70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351413, RefRangeEnd = 351415, XrefRangeStart = 351407, XrefRangeEnd = 351413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WellKnownClientTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x0011DAE0 File Offset: 0x0011BCE0
		public unsafe string ApplicationUrl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06003CBC RID: 15548 RVA: 0x0011DB18 File Offset: 0x0011BD18
		public unsafe Type ObjectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0011DB58 File Offset: 0x0011BD58
		public unsafe string ObjectUrl
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownClientTypeEntry.NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x0011DB90 File Offset: 0x0011BD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351415, XrefRangeEnd = 351417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WellKnownClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00016D8F File Offset: 0x00014F8F
		public WellKnownClientTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x0011DBD4 File Offset: 0x0011BDD4
		// (set) Token: 0x06003CC1 RID: 15553 RVA: 0x00016D98 File Offset: 0x00014F98
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x0011DC04 File Offset: 0x0011BE04
		// (set) Token: 0x06003CC3 RID: 15555 RVA: 0x00016DB7 File Offset: 0x00014FB7
		public unsafe string obj_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_obj_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x0011DC2C File Offset: 0x0011BE2C
		// (set) Token: 0x06003CC5 RID: 15557 RVA: 0x00016DD6 File Offset: 0x00014FD6
		public unsafe string app_url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownClientTypeEntry.NativeFieldInfoPtr_app_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003259 RID: 12889
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x0400325A RID: 12890
		private static readonly IntPtr NativeFieldInfoPtr_obj_url;

		// Token: 0x0400325B RID: 12891
		private static readonly IntPtr NativeFieldInfoPtr_app_url;

		// Token: 0x0400325C RID: 12892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x0400325D RID: 12893
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0;

		// Token: 0x0400325E RID: 12894
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400325F RID: 12895
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUrl_Public_get_String_0;

		// Token: 0x04003260 RID: 12896
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
