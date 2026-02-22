using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000386 RID: 902
	public sealed class ValueFixup : Object
	{
		// Token: 0x06003ABB RID: 15035 RVA: 0x00116864 File Offset: 0x00114A64
		// Note: this type is marked as 'beforefieldinit'.
		static ValueFixup()
		{
			Il2CppClassPointerStore<ValueFixup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ValueFixup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr);
			ValueFixup.NativeFieldInfoPtr_valueFixupEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "valueFixupEnum");
			ValueFixup.NativeFieldInfoPtr_arrayObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "arrayObj");
			ValueFixup.NativeFieldInfoPtr_indexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "indexMap");
			ValueFixup.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "header");
			ValueFixup.NativeFieldInfoPtr_memberObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "memberObject");
			ValueFixup.NativeFieldInfoPtr_valueInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "valueInfo");
			ValueFixup.NativeFieldInfoPtr_objectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "objectInfo");
			ValueFixup.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "memberName");
			ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100672030);
			ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100672031);
			ValueFixup.NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100672032);
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00116970 File Offset: 0x00114B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348689, RefRangeEnd = 348690, XrefRangeStart = 348688, XrefRangeEnd = 348689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueFixup(Array arrayObj, Il2CppStructArray<int> indexMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x001169D0 File Offset: 0x00114BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348690, XrefRangeEnd = 348691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueFixup(Object memberObject, string memberName, ReadObjectInfo objectInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00116A40 File Offset: 0x00114C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348691, XrefRangeEnd = 348698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fixup(ParseRecord record, ParseRecord parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00015F7B File Offset: 0x0001417B
		public ValueFixup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x00116A94 File Offset: 0x00114C94
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x00015F84 File Offset: 0x00014184
		public unsafe ValueFixupEnum valueFixupEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_valueFixupEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_valueFixupEnum)) = value;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x00116ABC File Offset: 0x00114CBC
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x00015F9F File Offset: 0x0001419F
		public unsafe Array arrayObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_arrayObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_arrayObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x00116AEC File Offset: 0x00114CEC
		// (set) Token: 0x06003AC5 RID: 15045 RVA: 0x00015FBE File Offset: 0x000141BE
		public unsafe Il2CppStructArray<int> indexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_indexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_indexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x00116B1C File Offset: 0x00114D1C
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x00015FDD File Offset: 0x000141DD
		public unsafe Object header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x00116B4C File Offset: 0x00114D4C
		// (set) Token: 0x06003AC9 RID: 15049 RVA: 0x00015FFC File Offset: 0x000141FC
		public unsafe Object memberObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06003ACA RID: 15050 RVA: 0x00116B7C File Offset: 0x00114D7C
		// (set) Token: 0x06003ACB RID: 15051 RVA: 0x0001601B File Offset: 0x0001421B
		public unsafe static MemberInfo valueInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueFixup.NativeFieldInfoPtr_valueInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueFixup.NativeFieldInfoPtr_valueInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x00116BA4 File Offset: 0x00114DA4
		// (set) Token: 0x06003ACD RID: 15053 RVA: 0x0001602D File Offset: 0x0001422D
		public unsafe ReadObjectInfo objectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_objectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_objectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x00116BD4 File Offset: 0x00114DD4
		// (set) Token: 0x06003ACF RID: 15055 RVA: 0x0001604C File Offset: 0x0001424C
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeFieldInfoPtr_valueFixupEnum;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeFieldInfoPtr_arrayObj;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeFieldInfoPtr_indexMap;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeFieldInfoPtr_memberObject;

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeFieldInfoPtr_valueInfo;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeFieldInfoPtr_objectInfo;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0;
	}
}
