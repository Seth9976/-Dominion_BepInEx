using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000349 RID: 841
	public sealed class SerializationEntry : ValueType
	{
		// Token: 0x06003616 RID: 13846 RVA: 0x001072A4 File Offset: 0x001054A4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEntry()
		{
			Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr);
			SerializationEntry.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "m_type");
			SerializationEntry.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "m_value");
			SerializationEntry.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, "m_name");
			SerializationEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100671641);
			SerializationEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100671642);
			SerializationEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr, 100671643);
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06003617 RID: 13847 RVA: 0x0010734C File Offset: 0x0010554C
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x00107390 File Offset: 0x00105590
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x001073CC File Offset: 0x001055CC
		[CallerCount(0)]
		public unsafe SerializationEntry(string entryName, Object entryValue, Type entryType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entryValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entryType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0001367C File Offset: 0x0001187C
		public SerializationEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00013685 File Offset: 0x00011885
		public SerializationEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x00107440 File Offset: 0x00105640
		// (set) Token: 0x0600361D RID: 13853 RVA: 0x00013697 File Offset: 0x00011897
		public unsafe Type m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x00107470 File Offset: 0x00105670
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x000136B6 File Offset: 0x000118B6
		public unsafe Object m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x001074A0 File Offset: 0x001056A0
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x000136D5 File Offset: 0x000118D5
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEntry.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Object_Type_0;
	}
}
