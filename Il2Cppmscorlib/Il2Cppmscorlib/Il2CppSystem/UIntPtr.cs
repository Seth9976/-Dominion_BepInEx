using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	[StructLayout(2)]
	public struct UIntPtr
	{
		// Token: 0x060016E0 RID: 5856 RVA: 0x00088BBC File Offset: 0x00086DBC
		// Note: this type is marked as 'beforefieldinit'.
		static UIntPtr()
		{
			Il2CppClassPointerStore<UIntPtr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UIntPtr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr);
			UIntPtr.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, "Zero");
			UIntPtr.NativeFieldInfoPtr__pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, "_pointer");
			UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667130);
			UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667131);
			UIntPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667132);
			UIntPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667133);
			UIntPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667134);
			UIntPtr.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667135);
			UIntPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UIntPtr_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667136);
			UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667137);
			UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667138);
			UIntPtr.NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, 100667139);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00088CDC File Offset: 0x00086EDC
		[CallerCount(0)]
		public unsafe UIntPtr(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00088D10 File Offset: 0x00086F10
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIntPtr(void* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00088D44 File Offset: 0x00086F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309384, XrefRangeEnd = 309387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00088D88 File Offset: 0x00086F88
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00088DB8 File Offset: 0x00086FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309387, XrefRangeEnd = 309393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00088DE4 File Offset: 0x00086FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309393, XrefRangeEnd = 309402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00088E34 File Offset: 0x00087034
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UIntPtr_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00088E80 File Offset: 0x00087080
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UIntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UIntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00088EC0 File Offset: 0x000870C0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UIntPtr(void* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00088EFC File Offset: 0x000870FC
		public unsafe static int Size
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 14937, RefRangeEnd = 14950, XrefRangeStart = 14937, XrefRangeEnd = 14950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIntPtr.NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00008165 File Offset: 0x00006365
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIntPtr>.NativeClassPtr, ref this));
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x00088F2C File Offset: 0x0008712C
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x00008177 File Offset: 0x00006377
		public unsafe static UIntPtr Zero
		{
			get
			{
				UIntPtr uintPtr;
				IL2CPP.il2cpp_field_static_get_value(UIntPtr.NativeFieldInfoPtr_Zero, (void*)(&uintPtr));
				return uintPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIntPtr.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr__pointer;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UIntPtr_UIntPtr_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UIntPtr_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UIntPtr_ptr_Void_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0;

		// Token: 0x04001501 RID: 5377
		[FieldOffset(0)]
		public IntPtr _pointer;
	}
}
