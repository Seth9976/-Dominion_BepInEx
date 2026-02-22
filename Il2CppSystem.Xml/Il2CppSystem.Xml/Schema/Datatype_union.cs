using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200008F RID: 143
	public class Datatype_union : Datatype_anySimpleType
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x000342C8 File Offset: 0x000324C8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_union()
		{
			Il2CppClassPointerStore<Datatype_union>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_union");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_union>.NativeClassPtr);
			Datatype_union.NativeFieldInfoPtr_atomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_union>.NativeClassPtr, "atomicValueType");
			Datatype_union.NativeFieldInfoPtr_listValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_union>.NativeClassPtr, "listValueType");
			Datatype_union.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_union>.NativeClassPtr, "types");
			Datatype_union.NativeMethodInfoPtr_HasAtomicMembers_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_union>.NativeClassPtr, 100664848);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00034348 File Offset: 0x00032548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22440, XrefRangeEnd = 22441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAtomicMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_union.NativeMethodInfoPtr_HasAtomicMembers_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00005AD6 File Offset: 0x00003CD6
		public Datatype_union(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00034384 File Offset: 0x00032584
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00005ADF File Offset: 0x00003CDF
		public new unsafe static Type atomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_union.NativeFieldInfoPtr_atomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_union.NativeFieldInfoPtr_atomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x000343AC File Offset: 0x000325AC
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00005AF1 File Offset: 0x00003CF1
		public new unsafe static Type listValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_union.NativeFieldInfoPtr_listValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_union.NativeFieldInfoPtr_listValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x000343D4 File Offset: 0x000325D4
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00005B03 File Offset: 0x00003D03
		public unsafe Il2CppReferenceArray<XmlSchemaSimpleType> types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datatype_union.NativeFieldInfoPtr_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Datatype_union.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_atomicValueType;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_listValueType;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_types;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_HasAtomicMembers_Internal_Boolean_0;
	}
}
