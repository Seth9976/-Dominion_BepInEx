using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200012F RID: 303
	[Serializable]
	[StructLayout(2)]
	public struct RuntimeFieldHandle
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x00084400 File Offset: 0x00082600
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeFieldHandle()
		{
			Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeFieldHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr);
			RuntimeFieldHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, "value");
			RuntimeFieldHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666965);
			RuntimeFieldHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666966);
			RuntimeFieldHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666967);
			RuntimeFieldHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666968);
			RuntimeFieldHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666969);
			RuntimeFieldHandle.NativeMethodInfoPtr_SetValueInternal_Private_Static_Void_FieldInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666970);
			RuntimeFieldHandle.NativeMethodInfoPtr_SetValue_Internal_Static_Void_RtFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666971);
			RuntimeFieldHandle.NativeMethodInfoPtr_SetValueDirect_Internal_Static_Void_RtFieldInfo_RuntimeType_ptr_Void_Object_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, 100666972);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000844E4 File Offset: 0x000826E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307909, XrefRangeEnd = 307922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00084534 File Offset: 0x00082734
		public unsafe IntPtr Value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00084564 File Offset: 0x00082764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307922, XrefRangeEnd = 307937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000845B4 File Offset: 0x000827B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307937, XrefRangeEnd = 307949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000845F8 File Offset: 0x000827F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00084628 File Offset: 0x00082828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307949, XrefRangeEnd = 307950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValueInternal(FieldInfo fi, Object obj, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_SetValueInternal_Private_Static_Void_FieldInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00084684 File Offset: 0x00082884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValue(RtFieldInfo field, Object obj, Object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fieldType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldAttr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &domainInitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_SetValue_Internal_Static_Void_RtFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00084720 File Offset: 0x00082920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307950, XrefRangeEnd = 307951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, Object value, RuntimeType contextType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fieldType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pTypedRef;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contextType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeFieldHandle.NativeMethodInfoPtr_SetValueDirect_Internal_Static_Void_RtFieldInfo_RuntimeType_ptr_Void_Object_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00007869 File Offset: 0x00005A69
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeFieldHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_SetValueInternal_Private_Static_Void_FieldInfo_Object_Object_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Static_Void_RtFieldInfo_Object_Object_RuntimeType_FieldAttributes_RuntimeType_byref_Boolean_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_SetValueDirect_Internal_Static_Void_RtFieldInfo_RuntimeType_ptr_Void_Object_RuntimeType_0;

		// Token: 0x0400125D RID: 4701
		[FieldOffset(0)]
		public IntPtr value;
	}
}
