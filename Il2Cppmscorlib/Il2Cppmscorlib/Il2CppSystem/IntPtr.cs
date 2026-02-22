using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200011D RID: 285
	[Serializable]
	[StructLayout(2)]
	public struct IntPtr
	{
		// Token: 0x06001466 RID: 5222 RVA: 0x0007F450 File Offset: 0x0007D650
		// Note: this type is marked as 'beforefieldinit'.
		static IntPtr()
		{
			Il2CppClassPointerStore<IntPtr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IntPtr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntPtr>.NativeClassPtr);
			IntPtr.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, "m_value");
			IntPtr.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, "Zero");
			IntPtr.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666782);
			IntPtr.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666783);
			IntPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666784);
			IntPtr.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666785);
			IntPtr.NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666786);
			IntPtr.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666787);
			IntPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666788);
			IntPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666789);
			IntPtr.NativeMethodInfoPtr_ToInt32_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666790);
			IntPtr.NativeMethodInfoPtr_ToInt64_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666791);
			IntPtr.NativeMethodInfoPtr_ToPointer_Public_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666792);
			IntPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666793);
			IntPtr.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666794);
			IntPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666795);
			IntPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666796);
			IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666797);
			IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666798);
			IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666799);
			IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666800);
			IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666801);
			IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_ptr_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666802);
			IntPtr.NativeMethodInfoPtr_IsNull_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, 100666803);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0007F660 File Offset: 0x0007D860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305833, RefRangeEnd = 305835, XrefRangeStart = 305833, XrefRangeEnd = 305833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0007F694 File Offset: 0x0007D894
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0007F6C8 File Offset: 0x0007D8C8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr(void* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0007F6FC File Offset: 0x0007D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305835, XrefRangeEnd = 305838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0007F74C File Offset: 0x0007D94C
		public unsafe static int Size
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 14937, RefRangeEnd = 14950, XrefRangeStart = 14937, XrefRangeEnd = 14950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0007F77C File Offset: 0x0007D97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305838, XrefRangeEnd = 305847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0007F7CC File Offset: 0x0007D9CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 305850, RefRangeEnd = 305855, XrefRangeStart = 305847, XrefRangeEnd = 305850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0007F810 File Offset: 0x0007DA10
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0007F840 File Offset: 0x0007DA40
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToInt32()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_ToInt32_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0007F870 File Offset: 0x0007DA70
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ToInt64()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_ToInt64_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0007F8A0 File Offset: 0x0007DAA0
		[CallerCount(0)]
		public unsafe void* ToPointer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_ToPointer_Public_ptr_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0007F8C8 File Offset: 0x0007DAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305857, RefRangeEnd = 305858, XrefRangeStart = 305855, XrefRangeEnd = 305857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0007F8F4 File Offset: 0x0007DAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305858, XrefRangeEnd = 305860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x0007F930 File Offset: 0x0007DB30
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(IntPtr value1, IntPtr value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0007F97C File Offset: 0x0007DB7C
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(IntPtr value1, IntPtr value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0007F9C8 File Offset: 0x0007DBC8
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 278883, RefRangeEnd = 278917, XrefRangeStart = 278883, XrefRangeEnd = 278917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0007FA08 File Offset: 0x0007DC08
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0007FA48 File Offset: 0x0007DC48
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(void* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0007FA84 File Offset: 0x0007DC84
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0007FAC4 File Offset: 0x0007DCC4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 71983, RefRangeEnd = 72005, XrefRangeStart = 71983, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0007FB04 File Offset: 0x0007DD04
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator void*(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_op_Explicit_Public_Static_ptr_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0007FB38 File Offset: 0x0007DD38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 305860, RefRangeEnd = 305866, XrefRangeStart = 305860, XrefRangeEnd = 305860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPtr.NativeMethodInfoPtr_IsNull_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00007250 File Offset: 0x00005450
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntPtr>.NativeClassPtr, ref this));
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0007FB68 File Offset: 0x0007DD68
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00007262 File Offset: 0x00005462
		public unsafe static IntPtr Zero
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntPtr.NativeFieldInfoPtr_Zero, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntPtr.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_Static_get_Int32_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Int32_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Int64_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_ToPointer_Public_ptr_Void_0;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_Int32_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_Int64_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ptr_Void_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_IntPtr_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_IntPtr_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ptr_Void_IntPtr_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Internal_Boolean_0;

		// Token: 0x04001184 RID: 4484
		[FieldOffset(0)]
		public IntPtr m_value;
	}
}
