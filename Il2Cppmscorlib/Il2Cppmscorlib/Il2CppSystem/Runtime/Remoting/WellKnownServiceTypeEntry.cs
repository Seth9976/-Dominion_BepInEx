using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A6 RID: 934
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		// Token: 0x06003CC6 RID: 15558 RVA: 0x0011DC54 File Offset: 0x0011BE54
		// Note: this type is marked as 'beforefieldinit'.
		static WellKnownServiceTypeEntry()
		{
			Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "WellKnownServiceTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr);
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_type");
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_uri");
			WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, "obj_mode");
			WellKnownServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672255);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672256);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672257);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672258);
			WellKnownServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr, 100672259);
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x0011DD24 File Offset: 0x0011BF24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351423, RefRangeEnd = 351424, XrefRangeStart = 351417, XrefRangeEnd = 351423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WellKnownServiceTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x0011DDA4 File Offset: 0x0011BFA4
		public unsafe WellKnownObjectMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x0011DDE0 File Offset: 0x0011BFE0
		public unsafe Type ObjectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x0011DE20 File Offset: 0x0011C020
		public unsafe string ObjectUri
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WellKnownServiceTypeEntry.NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x0011DE58 File Offset: 0x0011C058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351424, XrefRangeEnd = 351460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WellKnownServiceTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00016DF5 File Offset: 0x00014FF5
		public WellKnownServiceTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x0011DE9C File Offset: 0x0011C09C
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x00016DFE File Offset: 0x00014FFE
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x0011DECC File Offset: 0x0011C0CC
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x00016E1D File Offset: 0x0001501D
		public unsafe string obj_uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x0011DEF4 File Offset: 0x0011C0F4
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x00016E3C File Offset: 0x0001503C
		public unsafe WellKnownObjectMode obj_mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WellKnownServiceTypeEntry.NativeFieldInfoPtr_obj_mode)) = value;
			}
		}

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeFieldInfoPtr_obj_uri;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeFieldInfoPtr_obj_mode;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_WellKnownObjectMode_0;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_WellKnownObjectMode_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUri_Public_get_String_0;

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
