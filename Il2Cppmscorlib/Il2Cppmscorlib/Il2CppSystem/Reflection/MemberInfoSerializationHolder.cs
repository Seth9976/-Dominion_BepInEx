using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AC RID: 428
	[Serializable]
	public class MemberInfoSerializationHolder : Object
	{
		// Token: 0x06001BDE RID: 7134 RVA: 0x0009F488 File Offset: 0x0009D688
		// Note: this type is marked as 'beforefieldinit'.
		static MemberInfoSerializationHolder()
		{
			Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberInfoSerializationHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr);
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_memberName");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_reflectedType");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_signature");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_signature2");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_memberType");
			MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, "m_info");
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100667948);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100667949);
			MemberInfoSerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100667950);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100667951);
			MemberInfoSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr, 100667952);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0009F594 File Offset: 0x0009D794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316880, RefRangeEnd = 316882, XrefRangeStart = 316879, XrefRangeEnd = 316880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0009F610 File Offset: 0x0009D810
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 316931, RefRangeEnd = 316935, XrefRangeStart = 316882, XrefRangeEnd = 316931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Il2CppReferenceArray<Type> genericArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedClass);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature2);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0009F6B0 File Offset: 0x0009D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316935, XrefRangeEnd = 316970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfoSerializationHolder(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberInfoSerializationHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInfoSerializationHolder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0009F714 File Offset: 0x0009D914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316970, XrefRangeEnd = 316977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfoSerializationHolder.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0009F778 File Offset: 0x0009D978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316977, XrefRangeEnd = 317020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MemberInfoSerializationHolder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000099FB File Offset: 0x00007BFB
		public MemberInfoSerializationHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x00009A04 File Offset: 0x00007C04
		public unsafe string m_memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0009F800 File Offset: 0x0009DA00
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x00009A23 File Offset: 0x00007C23
		public unsafe RuntimeType m_reflectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_reflectedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0009F830 File Offset: 0x0009DA30
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x00009A42 File Offset: 0x00007C42
		public unsafe string m_signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0009F858 File Offset: 0x0009DA58
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x00009A61 File Offset: 0x00007C61
		public unsafe string m_signature2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_signature2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0009F880 File Offset: 0x0009DA80
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x00009A80 File Offset: 0x00007C80
		public unsafe MemberTypes m_memberType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_memberType)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0009F8A8 File Offset: 0x0009DAA8
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00009A9B File Offset: 0x00007C9B
		public unsafe SerializationInfo m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInfoSerializationHolder.NativeFieldInfoPtr_m_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_m_memberName;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr_m_reflectedType;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr_m_signature;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeFieldInfoPtr_m_signature2;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr_m_memberType;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_MemberTypes_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationInfo_Public_Static_Void_SerializationInfo_String_RuntimeType_String_String_MemberTypes_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;
	}
}
